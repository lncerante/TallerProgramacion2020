using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    /// <summary>
    /// Formulario que muestra todas las peliculas y series que un usuario tiene en su lista de seguimiento.
    /// </summary>
    public partial class FormWatchList : Form
    {
        private IEnumerable<WatchListItemDTO> watchList;
        protected WinFormsContext iContext;

        /// <summary>
        /// Crea una nueva instancia de la clase FormWatchList.
        /// </summary>
        public FormWatchList()
        {
            iContext = WinFormsContext.GetInstance();
            InitializeComponent();
        }

        /// <summary>
        /// Carga la lista de seguimiento.
        /// </summary>
        private void FormWatchList_Load(object sender, EventArgs e)
        {
            GetWatchList();
        }

        /// <summary>
        /// Obtiene la lista de seguimiento de un usuario.
        /// </summary>
        private void GetWatchList()
        {
            try
            {
                watchList = new WatchListController().GetWatchList();
                if (watchList != null)
                {
                    dataGridViewMedia.Rows.Clear();
                    buttonEditPriority.Visible = true;
                    foreach (var item in watchList)
                    {
                        dataGridViewMedia.Rows.Add
                        (
                            item.Priority.ToString(),
                            item.Media.ImdbID,
                            item.Media.Title,
                            item.Media.Year,
                            item.Media.MediaType.ToString(),
                            string.Join(", ", item.Media.Genres.Select(g => g.Name)),
                            item.Media.ImdbRating,
                            item.ITS?.ToShortDateString()
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                Tools.Log(ex);
                MessageBox.Show("Error trying to get WatchList.");
            }
        }

        /// <summary>
        /// Elimina una pelicula o serie de la lista de seguimiento.
        /// </summary>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedia.SelectedRows.Count == 1)
            {
                var idIMDB = dataGridViewMedia.CurrentRow.Cells["ColumnImdbID"].Value.ToString();
                var item = watchList.FirstOrDefault(i => i.Media.ImdbID == idIMDB);
                if (item != null && item.ID != null)
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this from your WatchList?", "Delete WatchList item", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            new WatchListController().DeleteWatchList((int)item.ID);
                        }
                        catch (Exception ex)
                        {
                            Tools.Log(ex);
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a WatchList item.");
                }
                GetWatchList();
            }
        }

        /// <summary>
        /// Muestra el formulario para calificar la película o serie seleccionada.
        /// </summary>
        private void ButtonRate_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedia.SelectedRows.Count == 1)
            {
                var idIMDB = dataGridViewMedia.CurrentRow.Cells["ColumnImdbID"].Value.ToString();
                var item = watchList.FirstOrDefault(i => i.Media.ImdbID == idIMDB);
                if (item != null && item.Media.ID != null)
                {
                    FormRateMovieOrSeries formRateMovieOrSeries = new FormRateMovieOrSeries((int)item.Media.ID);
                    formRateMovieOrSeries.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a WatchList item.");
                }
                GetWatchList();
            }
        }

        /// <summary>
        /// Permite editar la prioridad que se le había dado a una película o serie.
        /// </summary>
        private void ButtonEditPriority_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedia.SelectedRows.Count == 1)
            {
                var idIMDB = dataGridViewMedia.CurrentRow.Cells["ColumnImdbID"].Value.ToString();
                var item = watchList.FirstOrDefault(i => i.Media.ImdbID == idIMDB);
                if (item != null && item.Media.ID != null)
                {
                    FormMediaPriority formMediaPriority = new FormMediaPriority((int)item.Media.ID, item);
                    formMediaPriority.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a WatchList item.");
                }
                GetWatchList();
            }
        }

        /// <summary>
        /// Permite visualizar todos los datos de la película o serie seleccionada.
        /// </summary>
        private void ButtonSeeMoreInformation_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedia.SelectedRows.Count == 1)
            {
                var idIMDB = dataGridViewMedia.CurrentRow.Cells["ColumnImdbID"].Value.ToString();
                var item = watchList.FirstOrDefault(i => i.Media.ImdbID == idIMDB);
                if (item != null)
                {
                    FormSeeMoreInformation formSeeMoreInformation = new FormSeeMoreInformation(item.Media);
                    formSeeMoreInformation.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a WatchList item.");
                }
            }
        }
    }
}
