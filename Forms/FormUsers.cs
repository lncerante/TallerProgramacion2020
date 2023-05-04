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
    public partial class FormUsers : Form
    {
        private string imagePath;
        private byte[] imgByte = null;
        private int idSelected;
        readonly List<User> usersList = new List<User>();

        public FormUsers()
        {
            InitializeComponent();
        }


        private void FormUsers_Load(object sender, EventArgs e)
        {
            InitializeUsersGrid();
            ShowUsers();
        }

        private void ShowUsers()
        {
            dataGridViewUsers.Rows.Clear();
            dataGridViewUsers.Visible = true;
            dataGridViewUsers.Columns["ColumnProfilePicture"].Width = 110;
            foreach (var user in usersList)
            {
                Image imgProfile = ConvertByteArrayToImage(user.ProfilePhoto);
                dataGridViewUsers.Rows.Add(user.ID, imgProfile, user.UserName, user.PasswordHash, user.FullName);
            }
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

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (textBoxFullName.Text.Length == 0 || textBoxPassword.Text.Length == 0 ||
                textBoxUsername.Text.Length == 0 || imgByte == null)
            {
                ErrorMessage("Please enter all the data");
            }
            else
            {
                if (labelRegisterOrEdit.Text == "REGISTER NEW USER")
                {
                    //Aca deberia registrarse el usuario
                    User userDTO = new User
                    {
                        UserName = textBoxUsername.Text,
                        PasswordHash = textBoxPassword.Text,
                        FullName = textBoxFullName.Text,
                        ProfilePhoto = imgByte,
                        ID = usersList.Count
                    };
                    usersList.Add(userDTO);
                    //controlador.RegisterNewUser(userDTO);
                    MessageBox.Show("User successfully registered");
                    CleanForm();
                }
                else
                {
                    //ACA DEBERIA EDITARSE EL USUARIO
                    //controlador.EditUser(userDTO)

                    //PROVISORIO PARA PRUEBAS
                    usersList.RemoveAt(idSelected - 1);

                    User userDTO = new User
                    {
                        UserName = textBoxUsername.Text,
                        PasswordHash = textBoxPassword.Text,
                        FullName = textBoxFullName.Text,
                        ProfilePhoto = imgByte,
                        ID = idSelected,
                    };
                    usersList.Insert(idSelected - 1, userDTO);
                    CleanForm();
                    labelRegisterOrEdit.Text = "REGISTER NEW USER";
                    MessageBox.Show("User successfully edited");
                }
                ShowUsers();
            }
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
                textBoxPassword.Text = dataGridViewUsers.CurrentRow.Cells["ColumnPassword"].Value.ToString();
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
                idSelected = Int32.Parse(dataGridViewUsers.CurrentRow.Cells["columnId"].Value.ToString());
                //contolador.DeleteUser(idSelected);
                MessageBox.Show("User successfully deleted");
                ShowUsers();
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

        private Image ConvertByteArrayToImage(byte[] profilePhoto)
        {
            if (profilePhoto == null) return null;
            MemoryStream ms = new MemoryStream(profilePhoto);
            Bitmap bm = new Bitmap(ms);
            return bm;
        }

        //METODOS QUE DESPUES HAY QUE ELIMINAR
        private void InitializeUsersGrid()
        { ///Convierto la foto a byte[]
            Image img = Image.FromFile("D:\\Downloads\\foto.jpeg");
            byte[] imgByte = (byte[])(new ImageConverter()).ConvertTo(img, typeof(byte[]));

            User user1 = new User
            {
                ID = 1,
                FullName = "Pepito",
                UserName = "pepito123456999",
                PasswordHash = "sjsj8",
                ProfilePhoto = imgByte
            };
            User user2 = new User
            {
                ID = 2,
                FullName = "Pepito perez",
                UserName = "pepito2",
                PasswordHash = "sjsj89",
                ProfilePhoto = imgByte
            };
            User user3 = new User
            {
                ID = 3,
                FullName = "Juan perez",
                UserName = "pepito3",
                PasswordHash = "fde3sjsj89",
                ProfilePhoto = imgByte
            };
            usersList.Add(user1);
            usersList.Add(user2);
            usersList.Add(user3);
        }
    }
}
