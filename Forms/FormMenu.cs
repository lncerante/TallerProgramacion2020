using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerProgramacion2020.WinFormsContextClass;
using TallerProgramacion2020.MediaManager.Domain;
using TallerProgramacion2020.MediaManager.IO;
using TallerProgramacion2020.ToolsClass;

namespace TallerProgramacion2020.Forms
{
    public partial class FormMenu : Form
    {
        private Form activeForm = null;
        private int LX, LY;
        private Button currentButton;
        protected WinFormsContext iContext;


        public FormMenu()
        {
            iContext = WinFormsContext.GetInstance();
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        public void Reset()
        {
            if (iContext.User.UserRole != UserRole.Admin)
            {
                buttonManageUsers.Visible = false;
                panelDecoManageUsers.Visible = false;
            }
            richTextBoxUserName.Text = iContext.User.FullName;
            pictureBoxUser.Image = Tools.ConvertByteArrayToImage(iContext.User.ProfilePhoto);
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            labelTodayDate.Text = DateTime.Today.ToString("D");
            Reset();
        }

        private void ActiveButton(object buttonSender)
        {
            if (buttonSender != null)
            {
                if (currentButton != (Button)buttonSender)
                {
                    DisableButton();
                    currentButton = (Button)buttonSender;
                    currentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    labelTitle.Text = currentButton.Text;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void ButtonHome_Click(object sender, EventArgs e)
        {
            DisableButton();
            labelTitle.Text = "  Home";
            //labelTodayDate.Visible = true;
            //pictureBox1.Visible = true;
            activeForm?.Close();
        }

        private void OpenChildForm(Form childForm, object buttonSender)
        {
            activeForm?.Close();
            ActiveButton(buttonSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panelFormsContainer.Controls.Add(childForm);
            this.panelFormsContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ButtonSeeWatchList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormWatchList(), sender);
        }

        private void ButtonSeeReviews_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormReviews(), sender);
        }

        private void ButtonAddToList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSearchMoviesOrSeries(), sender);
        }

        private void ButtonProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProfile(), sender);
        }

        private void ButtonManageUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUsers(), sender);
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Waring", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ButtonMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonMaximized_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            buttonMaximized.Visible = false;
            buttonRestore.Visible = true;

            //PROBAR ESTO
            //if(WindowState == FormWindowState.Normal)
            //{
            //    WindowState = FormWindowState.Maximized;
            //}
            //else
            //{
            //    WindowState = FormWindowState.Normal;
            //}
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to close the application?","Waring",MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }

        private void ButtonRestore_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1300, 650);
            this.Location = new Point(LX, LY);
            buttonRestore.Visible = false;
            buttonMaximized.Visible = true;
        }

        //Function that allows dragging the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void PanelControls_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
