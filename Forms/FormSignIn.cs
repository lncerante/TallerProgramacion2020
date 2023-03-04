using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            if (labelUsername.Text.Length == 0 || labelPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter all the data", "Important!", MessageBoxButtons.OK);
            }
            else
            {
                //Mandar usuario y contraseña y ver si puede ingresar o no

                //Si ingresa:
                userSuccessfullyAuthenticated = true;

                // necesito saber si es el usuario es administrador o no
                adminUser = true;
                Close();
            }
        }
    }
}
