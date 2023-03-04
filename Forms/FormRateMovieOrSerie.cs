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
    public partial class FormRateMovieOrSerie : Form
    {
        readonly string idMedia;
        public FormRateMovieOrSerie(string imdbID)
        {
            idMedia = imdbID;
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(comboBoxType.Text.Length != 0 && richTextBox1!= null)
            {
                //va a tener que existir algo como GuardarComentario(idMedia,comboBoxType.Text,richTextBox1);
                MessageBox.Show("Commentario guardado");
                Close();
            }
        }
    }
}
