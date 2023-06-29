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
using TallerProgramacion2020.WinFormsContextClass;

namespace TallerProgramacion2020.Forms
{
    public partial class FormUsers : Form
    {
        private string imagePath;
        private byte[] imgByte = null;
        private int idSelected;
        protected WinFormsContext iContext;
        private IEnumerable<UserDTO> usersList = new List<UserDTO>();

        public FormUsers()
        {
            iContext = WinFormsContext.GetInstance();
            InitializeComponent();
        }


        private void FormUsers_Load(object sender, EventArgs e)
        {
            ShowUsers();
        }

        private void ShowUsers()
        {
            GetUserList();
            dataGridViewUsers.Rows.Clear();
            dataGridViewUsers.Visible = true;
            dataGridViewUsers.Columns["ColumnProfilePicture"].Width = 110;
            foreach (var user in usersList)
            {
                Image imgProfile = Tools.ConvertByteArrayToImage(user.ProfilePhoto);
                dataGridViewUsers.Rows.Add
                (
                    user.ID, 
                    imgProfile, 
                    user.UserName, 
                    user.UserRole == UserRole.Admin ? "Admin" : "User", 
                    user.FullName
                );
            }
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
            if (labelRegisterOrEdit.Text == "REGISTER NEW USER")
            {
                if (textBoxFullName.Text.Length == 0 || textBoxPassword.Text.Length == 0 ||
                    textBoxUsername.Text.Length == 0 || imgByte == null)
                {
                    ErrorMessage("Please enter all the data");
                    return;
                }
                UserDTO user = new UserDTO
                {
                    UserName = textBoxUsername.Text,
                    FullName = textBoxFullName.Text,
                    Password = textBoxPassword.Text,
                    ProfilePhoto = imgByte
                };
                try
                {
                    new UsersController().CreateUser(user);
                    labelRegisterOrEdit.Text = "REGISTER NEW USER";
                    MessageBox.Show("User successfully registered.");
                    CleanForm();
                }
                catch (Exception ex)
                {
                    ErrorMessage(ex.Message);
                }
            }
            else
            {
                UserDTO user = new UserDTO
                {
                    UserName = textBoxUsername.Text,
                    FullName = textBoxFullName.Text,
                    Password = textBoxPassword.Text,
                    ProfilePhoto = imgByte,
                    ID = idSelected
                };
                try
                {
                    new UsersController().UpdateUser(user);
                    if (user.ID == iContext.User.ID)
                    {
                        if (!string.IsNullOrEmpty(user.UserName)) iContext.User.UserName = user.UserName;
                        if (!string.IsNullOrEmpty(user.FullName)) iContext.User.FullName = user.FullName;
                        if (imgByte.Length > 0) iContext.User.ProfilePhoto = imgByte;
                        iContext.RootForm.Reset();
                    }
                    labelRegisterOrEdit.Text = "REGISTER NEW USER";
                    MessageBox.Show("User successfully edited.");
                    CleanForm();
                }
                catch (Exception ex)
                {
                    ErrorMessage(ex.Message);
                }
            }
            FormUsers_Load(sender, e);
        }

        private void CleanForm()
        {
            textBoxFullName.Clear();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            imgByte = null;
            labelErrorMessage.Visible = false;
        }

        private void ErrorMessage(string txt)
        {
            labelErrorMessage.Text = "      " + txt;
            labelErrorMessage.Visible = true;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            buttonCancel.Visible = true;
            if (dataGridViewUsers.SelectedRows.Count == 1)
            {
                labelRegisterOrEdit.Text = "EDIT USER";
                idSelected = Int32.Parse(dataGridViewUsers.CurrentRow.Cells["ColumnId"].Value.ToString());
                textBoxUsername.Text = dataGridViewUsers.CurrentRow.Cells["ColumnUsername"].Value.ToString();
                textBoxFullName.Text = dataGridViewUsers.CurrentRow.Cells["ColumnFullName"].Value.ToString();
                var img = (Image)dataGridViewUsers.CurrentRow.Cells["ColumnProfilePicture"].Value;
                imgByte = (byte[])(new ImageConverter()).ConvertTo(img, typeof(byte[]));
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            labelRegisterOrEdit.Text = "REGISTER NEW USER";
            buttonCancel.Visible = false;
            CleanForm();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 1)
            {
                idSelected = int.Parse(dataGridViewUsers.CurrentRow.Cells["columnId"].Value.ToString());
                var confirmResult = MessageBox.Show("Are you sure to delete this user?", "Delete user", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        new UsersController().DeleteUser(idSelected);
                        MessageBox.Show("User successfully deleted.");
                        ShowUsers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a review to delete.");
            }
        }

        private void GetUserList()
        {
            try
            {
                usersList = new UsersController().GetUsers();
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
        }
    }
}
