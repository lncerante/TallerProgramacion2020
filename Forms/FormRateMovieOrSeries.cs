using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerProgramacion2020.Forms
{
    public partial class FormRateMovieOrSeries : Form
    {
        readonly string idMedia;

        public FormRateMovieOrSeries(string imdbID)
        {
            idMedia = imdbID;
            InitializeComponent();
        }
        //IMPORTANTE
        //LOS VALORES DEL COMBOBOX DEBERIAN OBTENERSE DE LA BASE DE DATOS
        //POR SI EN ALGUN MOMENTO SE QUIEREN MODIFICAR 

        //Allows to drag a form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void PanelControls_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(comboBoxRating.Text.Length != 0 && richTextBox1!= null)
            {
                //va a tener que existir algo como GuardarComentario(idMedia,comboBoxType.Text,richTextBox1);
                MessageBox.Show("Comentario guardado");
                Close();
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
