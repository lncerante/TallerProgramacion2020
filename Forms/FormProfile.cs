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
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.Forms
{
    public partial class FormProfile : Form
    {
        private User user;
        private string imagePath;
        private byte[] imgByte = null;

        public FormProfile()
        {
            InitializeComponent();
        }

        private void UsuarioDePrueba()
        {
            Image img = Image.FromFile("D:\\Downloads\\foto.jpeg");
            imgByte = (byte[])(new ImageConverter()).ConvertTo(img, typeof(byte[]));

            user = new User
            {
                ID = 1,
                FullName = "Pepito",
                UserName = "pepito123456999",
                PasswordHash = "sjsj8",
                ProfilePhoto = imgByte
            };
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            UsuarioDePrueba();
            ShowUser();
            
        }

        private void ShowUser()
        {
            pictureBoxProfile.Image = ConvertByteArrayToImage(user.ProfilePhoto);
            labelUserFullName.Text = user.FullName;
            labelUserPassword.Text = user.PasswordHash;
            labelUserUsername.Text = user.UserName;
            labelUserFullName.Visible = true;
            labelUserPassword.Visible = true;
            labelUserUsername.Visible = true;
        }
        
        //IMPORTANTE VER
        //Esto capaz lo tendria que hacer el controlador. yo deberia enviar la imagen?
        private Image ConvertByteArrayToImage(byte[] profilePhoto)
        {
            if (profilePhoto == null) return null;
            MemoryStream ms = new MemoryStream(profilePhoto);
            Bitmap bm = new Bitmap(ms);
            return bm;
        }
        
        private void ConvertImageToByteArray(string imagePath)
        {
            if (imagePath != null)
            {
                Image img = Image.FromFile(imagePath);
                imgByte = (byte[])(new ImageConverter()).ConvertTo(img, typeof(byte[]));
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            labelUserFullName.Visible = false;
            labelUserPassword.Visible = false;
            labelUserUsername.Visible = false;
            buttonEdit.Visible = false;
            panelUsername.Visible = true;
            panelPassword.Visible = true;
            panelFullName.Visible = true;
            textBoxFullName.Visible = true;
            textBoxPassword.Visible = true;
            textBoxUsername.Visible = true;
            textBoxFullName.Text = user.FullName;
            textBoxPassword.Text = user.PasswordHash;
            textBoxUsername.Text = user.UserName; 
            //imgByte = user.ProfilePhoto;
            labelProfilePicture.Visible = true;
            buttonUploadPicture.Visible = true;
            buttonSaveChanges.Visible = true;
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

        private void ButtonSaveChanges_Click(object sender, EventArgs e)
        {
            if (textBoxFullName.Text.Length == 0 || textBoxPassword.Text.Length == 0 ||
                textBoxUsername.Text.Length == 0 || imgByte == null)
            {
                ErrorMessage("Please enter all the data");
            }
            else
            {
                labelErrorMessage.Visible = false;
                user = new User
                {
                    UserName = textBoxUsername.Text,
                    PasswordHash = textBoxPassword.Text,
                    FullName = textBoxFullName.Text,
                    ProfilePhoto = imgByte,
                };
                //controlador.EditUser(userDTO)
                buttonSaveChanges.Visible = false;
                panelUsername.Visible = false;
                panelPassword.Visible = false;
                panelFullName.Visible = false;
                textBoxFullName.Visible = false;
                textBoxPassword.Visible = false;
                textBoxUsername.Visible = false;
                labelProfilePicture.Visible = false;
                buttonUploadPicture.Visible =false;
                labelErrorMessage.Visible = false;
                buttonEdit.Visible = true;
                ShowUser();
            }
        }

        private void ErrorMessage(string txt)
        {
            labelErrorMessage.Text = "      " + txt;
            labelErrorMessage.Visible = true;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {

        }

    }
}
