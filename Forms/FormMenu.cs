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
    /// <summary>
    /// Representa un formulario de menú principal que permite navegar entre
    /// diferentes funcionalidades de la aplicación.
    /// </summary>
    public partial class FormMenu : Form
    {
        private Form activeForm = null;
        private int LX, LY;
        private Button currentButton;
        protected WinFormsContext iContext;

        /// <summary>
        /// Crea una nueva instancia de la clase FormMenu.
        /// </summary>
        public FormMenu()
        {
            iContext = WinFormsContext.GetInstance();
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        /// <summary>
        /// Restablece el estado inicial del formulario y determina que funciones estan disponibles según el rol del usuario.
        /// </summary>
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

        /// <summary>
        /// Se ejecuta al cargar el formulario y realiza tareas de inicialización y configuración.
        /// </summary>
        private void FormMenu_Load(object sender, EventArgs e)
        {
            labelTodayDate.Text = DateTime.Today.ToString("D");
            Reset();
        }

        /// <summary>
        /// Cambia de color el fondo del botón que está activo y muestra el título correspondiente.
        /// </summary>
        private void ActiveButton(object buttonSender)
        {
            if (buttonSender != null)
            {
                if (currentButton != (Button)buttonSender)
                {
                    DisableButton();
                    currentButton = (Button)buttonSender;
                    currentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    labelTitle.Text = currentButton.Text;
                }
            }
        }

        /// <summary>
        /// Vuelve al color original el fondo del botón que ya no está activo.
        /// </summary>
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        /// <summary>
        /// Permite volver al inicio del menú y cierra cualquier formulario activo.
        /// </summary>
        private void ButtonHome_Click(object sender, EventArgs e)
        {
            DisableButton();
            labelTitle.Text = "  Home";
            activeForm?.Close();
        }

        /// <summary>
        /// Abre un formulario secundario dentro de un formulario principal.
        /// </summary>
        /// <param name="childForm">Formulario secundario a abrir.</param>
        /// <param name="buttonSender">Botón que activó la apertura del formulario secundario.</param>
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

        /// <summary>
        /// Abre el formulario FormWatchList.
        /// </summary>
        private void ButtonSeeWatchList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormWatchList(), sender);
        }

        /// <summary>
        /// Abre el formulario FormReviews.
        /// </summary>
        private void ButtonSeeReviews_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormReviews(), sender);
        }

        /// <summary>
        /// Abre el formulario FormSearchMoviesOrSeries.
        /// </summary>
        private void ButtonAddToList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSearchMoviesOrSeries(), sender);
        }

        /// <summary>
        /// Abre el formulario FormProfile.
        /// </summary>
        private void ButtonProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProfile(), sender);
        }

        /// <summary>
        /// Abre el formulario FormUsers.
        /// </summary>
        private void ButtonManageUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormUsers(), sender);
        }

        /// <summary>
        /// Cierra la sesión del usuario.
        /// </summary>
        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Waring", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                iContext.Reset();
                this.Close();
            }
        }

        /// <summary>
        /// Permite minimizar la ventana.
        /// </summary>
        private void ButtonMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Permite maximizar la ventana.
        /// </summary>
        private void ButtonMaximized_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            buttonMaximized.Visible = false;
            buttonRestore.Visible = true;
        }

        /// <summary>
        /// Cierra la aplicación.
        /// </summary>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to close the application?","Waring",MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }

        /// <summary>
        /// Cambia la ventana a su tamaño original.
        /// </summary>
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
        /// <summary>
        /// Habilita el arrastre del formulario al hacer clic.
        /// </summary>
        private void PanelControls_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
