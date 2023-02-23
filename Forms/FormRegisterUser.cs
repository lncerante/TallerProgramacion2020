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
    public partial class FormRegisterUser : Form
    {
        private string urlProfilePicture; 

        public FormRegisterUser()
        {
            urlProfilePicture = "";
            InitializeComponent();
        }

        private void ButtonUploadPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                urlProfilePicture = openFileDialog1.FileName;
            }
            else { }
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxFullName.Text.Length == 0 || textBoxPassword.Text.Length == 0 ||
                textBoxUsername.Text.Length == 0 || urlProfilePicture == "")
            {
                MessageBox.Show("Please enter all the data", "Important!", MessageBoxButtons.OK);
            }
            else
            {
                //Aca deberia registrarse el usuario
                MessageBox.Show("Admin user successfully registered");
                FormSignIn formSignIn = new FormSignIn();
                formSignIn.Show();
            }
        }
    }
}
