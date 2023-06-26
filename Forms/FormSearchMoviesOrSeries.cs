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
    public partial class FormSearchMoviesOrSeries : Form
    {
        private IEnumerable<MediaDTO> mediaList;
        protected WinFormsContext iContext;

        public FormSearchMoviesOrSeries()
        {
            iContext = WinFormsContext.GetInstance();
            InitializeComponent();
        }

        private void FormSearchMoviesOrSeries_Load(object sender, EventArgs e)
        {
            dataGridViewMedia.Visible = false;
            GetMediaList();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
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

                mediaList = new MediaController().SearchMedia
                (
                    textBoxSearchTitle.Text,
                    textBoxGenre.Text,
                    mediaType
                );

                if(mediaList != null)
                {
                    labelErrorMessage.Visible = false;
                    dataGridViewMedia.Rows.Clear();
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
                else
                {
                    ErrorMessage("There are no exact results for the words entered. Try again!");
                }                
            }
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
                FormRateMovieOrSeries formRateMoviesOrSeries = new FormRateMovieOrSeries(idIMDB);
                formRateMoviesOrSeries.ShowDialog();
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

        private void ButtonAddToMyList_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedia.SelectedRows.Count == 1)
            {
                var idIMDB = dataGridViewMedia.CurrentRow.Cells["ColumnImdbID"].Value.ToString();
                //var exist = controlador.MediaAlreadyExist(idIMDB);
                var exist = false;
                if (exist)
                {
                    MessageBox.Show("This media already exists in your watchlist");
                }
                else
                {
                    FormMediaPriority formMediaPriority = new FormMediaPriority(idIMDB);
                    formMediaPriority.ShowDialog();
                }
                
            }
        }

        //Metodos que hay que eliminar despues
        private void GetMediaList()
        {
            try
            {
                mediaList = new MediaController().GetMedia();
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
        }
    }
}
