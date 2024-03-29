﻿using System;
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
using TallerProgramacion2020.MediaManager.Controllers;
using TallerProgramacion2020.WinFormsContextClass;

namespace TallerProgramacion2020.Forms
{
    /// <summary>
    /// Formulario que permite a un usuario iniciar sesión.
    /// </summary>
    public partial class FormSignIn : Form
    {
        public bool userSuccessfullyAuthenticated;
        protected WinFormsContext iContext;

        /// <summary>
        /// Crea una nueva instancia de la clase FormSignIn.
        /// </summary>
        public FormSignIn()
        {
            iContext = WinFormsContext.GetInstance();
            InitializeComponent();
            userSuccessfullyAuthenticated = false;
        }

        //Permite arrastrar el formulario.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
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

        /// <summary>
        /// Determina si el usuario puede ingresar o no a la aplicación.
        /// </summary>
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
            }
            else
            {
                var user = new SignInController().SignIn(textBoxUsername.Text, textBoxPassword.Text);
                if (user != null)
                {
                    iContext.User = user;
                    FormMenu formMenu = new FormMenu();
                    iContext.RootForm = formMenu;
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

        /// <summary>
        /// Etiqueta que muestra un mensjae de error.
        /// </summary>
        /// <param name="txt">Mensaje de error.</param>
        private void ErrorMessage(string txt)
        {
            labelErrorMessage.Text = "      "+txt;
            labelErrorMessage.Visible = true;
        }

        /// <summary>
        /// Minimiza la ventana.
        /// </summary>
        private void ButtonMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Cierra la aplicación.
        /// </summary>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Limpia la pantalla luego de que un usuario cierra sesión.
        /// </summary>
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
