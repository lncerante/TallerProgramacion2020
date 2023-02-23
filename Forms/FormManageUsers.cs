using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.Forms
{
    public partial class FormManageUsers : Form
    {
        readonly User user = new User();
        readonly List<User> listaUsuarios = new List<User>();
        DataTable table = new DataTable();

        public FormManageUsers()
        {
            InitializeComponent();
        }

        private void ButtonSeeRegistersUsers_Click(object sender, EventArgs e)
        {
            //Aca deberiamos llamar a la lista de usuarios real, por ahora es
            //una lista creada asi no mas.
            //A esto solo lo puede ver el usuario administrador, no cualquier usuario

            table.Columns.Add("Id");
            table.Columns.Add("Profile photo");
            table.Columns.Add("Full Name");
            table.Columns.Add("Username");
            table.Columns.Add("Password");
            dataGridView1.DataSource = table;
            User user1 = new User
            {
                FullName = "Pepito",
                UserName = "pepito1",
                PasswordHash = "sjsj8"
            };
            User user2 = new User
            {
                FullName = "Pepito perez",
                UserName = "pepito2",
                PasswordHash = "sjsj89"
            };
            User user3 = new User
            {
                FullName = "Juan perez",
                UserName = "pepito3",
                PasswordHash = "fde3sjsj89"
            };
            listaUsuarios.Add(user1);
            listaUsuarios.Add(user2);
            listaUsuarios.Add(user3);
            foreach (var user in listaUsuarios)
            {
                DataRow row = table.NewRow();
                row[0] = user.ID;
                row[1] = user.ProfilePhoto;
                row[2] = user.FullName;
                row[3] = user.UserName;
                row[4] = user.PasswordHash;
                table.Rows.Add(row);
            }
        }

        private void ButtonRegisterNewUser_Click(object sender, EventArgs e)
        {
            FormRegisterUser formCreateUser = new FormRegisterUser();
            formCreateUser.Show();
        }
    }
}
