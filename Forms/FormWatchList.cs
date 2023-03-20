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
    public partial class FormWatchList : Form
    {
        public FormWatchList()
        {
            InitializeComponent();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedia.SelectedRows.Count == 1)
            {
                var idIMDB = dataGridViewMedia.CurrentRow.Cells["ColumnImdbID"].Value.ToString();
                //controlador.DeleteMediaWatchList(idIMDB)
            }
        }

        private void ButtonRate_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedia.SelectedRows.Count == 1)
            {
                var idIMDB = dataGridViewMedia.CurrentRow.Cells["ColumnImdbID"].Value.ToString();
                FormRateMovieOrSeries formRateMoviesOrSeries = new FormRateMovieOrSeries(idIMDB);
                formRateMoviesOrSeries.ShowDialog();
            }
        }

        private void ButtonEditPriority_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedia.SelectedRows.Count == 1)
            {
                var idIMDB = dataGridViewMedia.CurrentRow.Cells["ColumnImdbID"].Value.ToString();
                FormMediaPriority formMediaPriority = new FormMediaPriority(idIMDB);
                formMediaPriority.ShowDialog();
            }
        }

        private void ButtonSeeMoreInformation_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedia.SelectedRows.Count == 1)
            {
                var idIMDB = dataGridViewMedia.CurrentRow.Cells["ColumnImdbID"].Value.ToString();
                FormSeeMoreInformation formSeeMoreInformation = new FormSeeMoreInformation(idIMDB);
                formSeeMoreInformation.ShowDialog();
            }                
        }
    }
}
