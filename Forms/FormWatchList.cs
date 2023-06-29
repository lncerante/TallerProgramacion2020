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
using TallerProgramacion2020.WinFormsContextClass;

namespace TallerProgramacion2020.Forms
{
    public partial class FormWatchList : Form
    {
        private IEnumerable<WatchListItemDTO> watchList;
        protected WinFormsContext iContext;

        public FormWatchList()
        {
            iContext = WinFormsContext.GetInstance();
            InitializeComponent();
        }

        private void FormWatchList_Load(object sender, EventArgs e)
        {
            GetWatchList();
        }

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
            catch
            {
                MessageBox.Show("Error trying to get WatchList.");
            }
        }

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
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a WatchList item to delete.");
                }
                GetWatchList();
            }
        }

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
                    MessageBox.Show("Error trying to open review.");
                }
                GetWatchList();
            }
        }

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
                    MessageBox.Show("Error trying to open WatchList item.");
                }
                GetWatchList();
            }
        }

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
                    MessageBox.Show("Error trying to open media.");
                }
            }
        }
    }
}
