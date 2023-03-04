using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.Forms
{
    public partial class FormManageUsers : Form
    {
        readonly List<User> listaUsuarios = new List<User>();

        public FormManageUsers()
        {
            InitializeComponent();
        }

        private void ButtonSeeRegistersUsers_Click(object sender, EventArgs e)
        {
            //Aca deberiamos llamar a la lista de usuarios real, por ahora es una lista creada asi no mas.
            //Hay que validar que a esto solo lo pueda ver el usuario administrador, no cualquier usuario.
            ShowUsers();
        }

        private void ShowUsers()
        {
            dataGridViewUsers.Rows.Clear(); 
            dataGridViewUsers.Visible = true;
            foreach (var user in listaUsuarios)
            {
                dataGridViewUsers.Rows.Add(user.ID, user.UserName,user.PasswordHash,user.FullName,user.ProfilePhoto);
            }
        }

        private void InitializeUsersGrid()
        {
            User user1 = new User
            {
                ID = 1,
                FullName = "Pepito",
                UserName = "pepito1",
                PasswordHash = "sjsj8"
            };
            User user2 = new User
            {
                ID = 2,
                FullName = "Pepito perez",
                UserName = "pepito2",
                PasswordHash = "sjsj89"
            };
            User user3 = new User
            {
                ID = 3,
                FullName = "Juan perez",
                UserName = "pepito3",
                PasswordHash = "fde3sjsj89"
            };
            listaUsuarios.Add(user1);
            listaUsuarios.Add(user2);
            listaUsuarios.Add(user3);
        }

        private void ButtonRegisterNewUser_Click(object sender, EventArgs e)
        {
            FormRegisterUser formCreateUser = new FormRegisterUser();
            formCreateUser.ShowDialog();
        }

        private void FormManageUsers_Load(object sender, EventArgs e)
        {
            dataGridViewUsers.Visible = false;
            InitializeUsersGrid();

        }

        private void DataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell) dataGridViewUsers.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Delete") 
            {
                var idToDelete = dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value;
                listaUsuarios.RemoveAt((int)idToDelete-1);//ACA HAY QUE LLAMAR A LA ELIMINACION REAL DE USUARIOS
                ShowUsers();
            }
        }
    }
}
