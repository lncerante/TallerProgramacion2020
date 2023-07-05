using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerProgramacion2020.MediaManager.Controllers;
using TallerProgramacion2020.MediaManager.Domain;
using TallerProgramacion2020.MediaManager.IO;
using TallerProgramacion2020.WinFormsContextClass;

namespace TallerProgramacion2020.Forms
{
    public partial class FormSearchMoviesOrSeries : Form
    {
        protected IEnumerable<MediaDTO> mediaList;
        protected WinFormsContext iContext;

        public FormSearchMoviesOrSeries()
        {
            iContext = WinFormsContext.GetInstance();
            InitializeComponent();
        }

        private void FormSearchMoviesOrSeries_Load(object sender, EventArgs e)
        {
            Loading(false);
            dataGridViewMedia.Visible = false;
        }

        public void Loading(bool isLoading)
        {
            panelLoading.BackColor = Color.FromArgb(20, Color.Blue);
            if (isLoading)
            {
                panelLoading.BringToFront();
                panelLoading.Show();
            }
            else
            {
                panelLoading.Hide();
                panelLoading.SendToBack();
            }
        }

        private void SearchMedia(bool forceApiSearch = false)
        {
            if (textBoxSearchTitle.Text.Length == 0 && textBoxGenre.Text.Length == 0 && comboBoxType.Text.Length == 0)
            {
                ErrorMessage("Please enter a title to search, a genre, or a type.");
            }
            else
            {
                MediaType? mediaType = null;
                if (comboBoxType.Text == "Movie")
                {
                    mediaType = MediaType.Movie;
                }
                else if (comboBoxType.Text == "Series")
                {
                    mediaType = MediaType.Series;
                }

                Loading(true);
                try
                {
                    mediaList = new MediaController().SearchMedia
                    (
                        textBoxSearchTitle.Text,
                        textBoxGenre.Text,
                        mediaType,
                        forceApiSearch
                    );
                }
                catch
                {
                    MessageBox.Show("Error trying to call media API. Please try again or modify your search parameters.");
                    mediaList = null;
                }

                dataGridViewMedia.Rows.Clear();
                Loading(false);
                if (mediaList != null)
                {
                    iContext.CurrentMedia = mediaList;
                    ShowMedia();
                }
                else
                {
                    ErrorMessage("There are no results for the words entered. Try again!");
                }
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchMedia(false);
        }

        private void buttonOnlineSearch_Click(object sender, EventArgs e)
        {
            SearchMedia(true);
        }

        private void ErrorMessage(string txt)
        {
            labelErrorMessage.Text = "      " + txt;
            labelErrorMessage.Visible = true;
        }

        private void ButtonRate_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedia.SelectedRows.Count == 1)
            {
                var idIMDB = dataGridViewMedia.CurrentRow.Cells["ColumnImdbID"].Value.ToString();
                var media = mediaList.FirstOrDefault(m => m.ImdbID == idIMDB);
                if (media != null && media.ID != null)
                {
                    FormRateMovieOrSeries formRateMoviesOrSeries = new FormRateMovieOrSeries((int)media.ID);
                    formRateMoviesOrSeries.ShowDialog();
                }
                else
                {
                    ErrorMessage("Error trying to open media.");
                }
            }
        }

        private void ButtonSeeMoreInformation_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedia.SelectedRows.Count == 1)
            {
                var idIMDB = dataGridViewMedia.CurrentRow.Cells["ColumnImdbID"].Value.ToString();
                var media = mediaList.FirstOrDefault(m => m.ImdbID == idIMDB);
                if (media != null)
                {
                    FormSeeMoreInformation formSeeMoreInformation = new FormSeeMoreInformation(media);
                    formSeeMoreInformation.ShowDialog();
                }
                else
                {
                    ErrorMessage("Error trying to open media.");
                }
            }
        }

        private void ButtonAddToMyList_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedia.SelectedRows.Count == 1)
            {
                var idIMDB = dataGridViewMedia.CurrentRow.Cells["ColumnImdbID"].Value.ToString();
                var media = mediaList.FirstOrDefault(m => m.ImdbID == idIMDB);
                if (media != null && media.ID != null)
                {
                    FormMediaPriority formMediaPriority = new FormMediaPriority((int)media.ID);
                    formMediaPriority.ShowDialog();
                }
                else
                {
                    ErrorMessage("Error trying to open media.");
                }
            }
        }

        private void ShowMedia()
        {
            if (mediaList != null)
            {
                labelErrorMessage.Visible = false;
                dataGridViewMedia.Visible = true;
                buttonAddToMyList.Visible = true;
                buttonRate.Visible = true;
                buttonSeeMoreInformation.Visible = true;
                foreach (var media in mediaList)
                {
                    dataGridViewMedia.Rows.Add
                    (
                        media.ImdbID,
                        media.Title,
                        media.Year,
                        media.MediaType,
                        string.Join(", ", media.Genres.Select(genre => genre.Name)),
                        media.ImdbRating
                    );
                }
            }
        }
    }
}
