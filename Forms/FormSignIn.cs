using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerProgramacion2020.MediaManager.IO;
using System.Runtime.InteropServices;

namespace TallerProgramacion2020.Forms
{
    public partial class FormSignIn : Form
    {
        public bool userSuccessfullyAuthenticated;
        public bool adminUser;

        public FormSignIn()
        {
            InitializeComponent();
            userSuccessfullyAuthenticated = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text.Length == 0 && textBoxPassword.Text.Length == 0)
            {
                textBoxUsername.Focus();
                ErrorMessage("Please enter your username and password.");
            }
            else if (textBoxUsername.Text.Length == 0 )
            {
                textBoxUsername.Focus();
                ErrorMessage("Please enter your username.");
            }
            else if(textBoxPassword.Text.Length == 0)
            {
                textBoxPassword.Focus();
                ErrorMessage("Please enter your password.");
            }else
            {
                //Mandar usuario y contraseña y ver si puede ingresar o no
                UserDTO userDTO = new UserDTO
                {
                    UserName = textBoxUsername.Text,
                    PasswordHash = textBoxPassword.Text,
                };
                //Quedaria algo como controlador.ValidSignIn(userDTO);
                var validSignIn = true;
                if (validSignIn)
                {
                    //Si el usuario es valido lo mando al menu
                    //Capaz al form menu le tenga que pasar el nombre de usario
                    Form1 formMenu = new Form1();
                    formMenu.Show();
                    formMenu.FormClosed += LogOut;
                    this.Hide();
                }
                else
                {
                    textBoxPassword.Clear();
                    textBoxUsername.Clear();
                    textBoxUsername.Focus();
                    ErrorMessage("The password or username you've entered is incorrect. \n      Please try again!");
                }
            }
        }

        private void ErrorMessage(string txt)
        {
            labelErrorMessage.Text = "      "+txt;
            labelErrorMessage.Visible = true;
        }

        private void ButtonMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Esto me permite mover la ventana
        private void FormSignIn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PictureBoxLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LogOut(object sender, FormClosedEventArgs e)
        {
            labelErrorMessage.Visible = false;
            textBoxPassword.Clear();
            textBoxUsername.Clear();
            textBoxUsername.Focus();
            this.Show();
        }
    }
}
