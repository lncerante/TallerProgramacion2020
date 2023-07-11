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
using TallerProgramacion2020.MediaManager.IO;
using TallerProgramacion2020.MediaManager.Controllers;
using TallerProgramacion2020.ToolsClass;
using TallerProgramacion2020.WinFormsContextClass;

namespace TallerProgramacion2020.Forms
{
    public partial class FormProfile : Form
    {
        private string imagePath;
        private byte[] imgByte = null;
        protected WinFormsContext iContext;

        public FormProfile()
        {
            iContext = WinFormsContext.GetInstance();
            InitializeComponent();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            ShowUser();
        }

        private void ShowUser()
        {
            pictureBoxProfile.Image = Tools.ConvertByteArrayToImage(iContext.User.ProfilePhoto);
            labelUserFullName.Text = iContext.User.FullName;
            labelUserUsername.Text = iContext.User.UserName;
            labelUserFullName.Visible = true;
            labelUserUsername.Visible = true;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            labelUserFullName.Visible = false;
            labelUserUsername.Visible = false;
            buttonEdit.Visible = false;
            panelUsername.Visible = true;
            panelPassword.Visible = true;
            panelOldPassword.Visible = true;
            panelFullName.Visible = true;
            textBoxFullName.Visible = true;
            textBoxPassword.Visible = true;
            textBoxOldPassword.Visible = true;
            textBoxUsername.Visible = true;
            textBoxFullName.Text = iContext.User.FullName;
            textBoxUsername.Text = iContext.User.UserName;
            imgByte = iContext.User.ProfilePhoto;
            labelProfilePicture.Visible = true;
            labelPassword.Visible = true;
            labelOldPassword.Visible = true;
            buttonUploadPicture.Visible = true;
            buttonSaveChanges.Visible = true;
            buttonCancel.Visible = true;
        }

        private void ButtonUploadPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialogUploadPicture.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialogUploadPicture.FileName;
                try
                {
                    imgByte = Tools.ConvertImageToByteArray(imagePath);
                }
                catch (Exception ex)
                {
                    Tools.Log(ex);
                    MessageBox.Show("Error while processing image.");
                }
            }
            else
            {
                MessageBox.Show("Something went wrong.");
            }
        }

        private void ButtonSaveChanges_Click(object sender, EventArgs e)
        {
            if
            (
                textBoxPassword.Text.Length > 0 &&
                textBoxOldPassword.Text.Length == 0
            )
            {
                ErrorMessage("Please enter your old password.");
            }
            else
            {
                labelErrorMessage.Visible = false;
                UserDTO user = new UserDTO
                {
                    UserName = textBoxUsername.Text,
                    FullName = textBoxFullName.Text,
                    Password = textBoxPassword.Text,
                    ProfilePhoto = imgByte,
                    ID = iContext.User.ID
                };
                try
                {
                    new ProfileController().UpdateUser(user, textBoxOldPassword.Text);

                    if (!string.IsNullOrEmpty(user.UserName)) iContext.User.UserName = user.UserName;
                    if (!string.IsNullOrEmpty(user.FullName)) iContext.User.FullName = user.FullName;
                    if (imgByte.Length > 0) iContext.User.ProfilePhoto = imgByte;
                    iContext.RootForm.Reset();

                    buttonSaveChanges.Visible = false;
                    buttonCancel.Visible = false;
                    panelUsername.Visible = false;
                    panelPassword.Visible = false;
                    panelOldPassword.Visible = false;
                    panelFullName.Visible = false;
                    textBoxFullName.Visible = false;
                    textBoxPassword.Visible = false;
                    textBoxOldPassword.Visible = false;
                    textBoxUsername.Visible = false;
                    labelProfilePicture.Visible = false;
                    labelPassword.Visible = false;
                    labelOldPassword.Visible = false;
                    buttonUploadPicture.Visible = false;
                    labelErrorMessage.Visible = false;
                    buttonEdit.Visible = true;
                    ShowUser();
                }
                catch (Exception ex)
                {
                    
                    ErrorMessage(ex.Message);
                }
            }
        }

        private void ErrorMessage(string txt)
        {
            labelErrorMessage.Text = "      " + txt;
            labelErrorMessage.Visible = true;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            labelUserFullName.Visible = true;
            labelUserUsername.Visible = true;
            buttonEdit.Visible = true;
            panelUsername.Visible = false;
            panelPassword.Visible = false;
            panelOldPassword.Visible = false;
            panelFullName.Visible = false;
            textBoxFullName.Visible = false;
            textBoxPassword.Visible = false;
            textBoxOldPassword.Visible = false;
            textBoxUsername.Visible = false;
            labelProfilePicture.Visible = false;
            labelPassword.Visible = false;
            labelOldPassword.Visible = false;
            buttonUploadPicture.Visible = false;
            buttonSaveChanges.Visible = false;
        }
    }
}
