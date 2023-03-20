﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerProgramacion2020.MediaManager.Domain;
using TallerProgramacion2020.MediaManager.IO;

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
                ConvertImageToByteArray(imagePath);
            }
            else
            {
                MessageBox.Show("Something went wrong.");
            }
        }

        //IMPORTANTE VER
        //Esto capaz lo tendria que hacer el controlador. yo deberia enviar la imagen?
        private void ConvertImageToByteArray(string imagePath)
        {
            if (imagePath != null)
            {
                Image img = Image.FromFile(imagePath);
                imgByte = (byte[])(new ImageConverter()).ConvertTo(img, typeof(byte[]));
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
                //Aca deberia registrarse el administrador
                User userDTO = new User
                {
                    UserName = textBoxUsername.Text,
                    PasswordHash = textBoxPassword.Text,
                    FullName = textBoxFullName.Text,
                    ProfilePhoto = imgByte,
                    // UserRoles = administrador
                };
                //controlador.RegisterNewUser(userDTO);
                MessageBox.Show("Administrator successfully registered");
            }
        }

        private void ErrorMessage(string txt)
        {
            labelErrorMessage.Text = "      " + txt;
            labelErrorMessage.Visible = true;
        }
    }
}