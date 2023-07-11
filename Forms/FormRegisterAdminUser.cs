using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerProgramacion2020.MediaManager.Controllers;
using TallerProgramacion2020.MediaManager.Domain;
using TallerProgramacion2020.MediaManager.IO;
using TallerProgramacion2020.ToolsClass;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TallerProgramacion2020.Forms
{
    public partial class FormRegisterAdminUser : Form
    {
        private string imagePath;
        private byte[] imgByte = null;

        public FormRegisterAdminUser()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonUploadPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialogUploadPicture.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialogUploadPicture.FileName;
                imgByte = Tools.ConvertImageToByteArray(imagePath);
            }
            else
            {
                MessageBox.Show("Something went wrong.");
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (textBoxFullName.Text.Length == 0 || textBoxPassword.Text.Length == 0 ||
                textBoxUsername.Text.Length == 0 || imgByte == null)
            {
                ErrorMessage("Please enter all the data");
            }
            else
            {
                UserDTO userDTO = new UserDTO
                {
                    UserName = textBoxUsername.Text,
                    Password = textBoxPassword.Text,
                    FullName = textBoxFullName.Text,
                    ProfilePhoto = imgByte
                };

                try
                {
                    new SignInController().RegisterAdmin(userDTO);
                    FormSignIn formSignIn = new FormSignIn();
                    formSignIn.Show();
                    Hide();
                    MessageBox.Show("Administrator successfully registered");
                }
                catch (Exception ex)
                {
                    Tools.Log(ex);
                    ErrorMessage(ex.Message);
                }
            }
        }

        private void ErrorMessage(string txt)
        {
            labelErrorMessage.Text = "      " + txt;
            labelErrorMessage.Visible = true;
        }
    }
}
