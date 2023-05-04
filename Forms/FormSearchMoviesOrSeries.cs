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
    public partial class FormSearchMoviesOrSeries : Form
    {
        private readonly List<Media> mediaList = new List<Media>();
        private string genres; 

        public FormSearchMoviesOrSeries()
        {
            InitializeComponent();
        }

        private void FormSearchMoviesOrSeries_Load(object sender, EventArgs e)
        {
            dataGridViewMedia.Visible = false;
            InitializeMediaGrid();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            
            if (textBoxSearchTitle.Text.Length == 0 || textBoxGenre.Text.Length == 0 || comboBoxType.Text.Length == 0)
            {
                ErrorMessage("Please enter a title to search, select a genre or / and a type");
            }
            else
            {
                //Mando a buscar al controlador. Seria algo como
                //mediaList= controlador.Search(dtoSearch)
                //Donde ses dto tenga textBoxSearchTitle.Text textBoxGenre.Text comboBoxType.Text
                //Si la busqueda me devuelve una lista no vacia, la muestro
                if(mediaList!= null)
                {
                    labelErrorMessage.Visible = false;
                    dataGridViewMedia.Rows.Clear();
                    dataGridViewMedia.Visible = true;
                    buttonAddToMyList.Visible = true;
                    buttonRate.Visible = true;
                    buttonSeeMoreInformation.Visible = true;
                    foreach (var media in mediaList)
                    {
                        var listGenres = new List<String>();
                        foreach (var genre in media.Genres)
                        {
                            listGenres.Add(genre.Name);   
                        }
                        genres = String.Join(", ", listGenres);
                        dataGridViewMedia.Rows.Add(media.ImdbID, media.Title,media.Year, media.MediaType,
                        genres, media.ImdbRating);
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
        private void InitializeMediaGrid()
        {
            //mediaList= la funcion buscar que tenga como parametros el tipo genero o titulo que quiere el usuario
            Genre genLK1 = new Genre("Animation");
            Genre genLK3 = new Genre("Adventure");
            Genre genLK5 = new Genre("Drama");
            List<Genre> gensLK = new List<Genre>
            {
                genLK1, genLK3, genLK5
            };

            Genre genC1 = new Genre("Adventure");
            Genre genC2 = new Genre("Drama");
            Genre genC3 = new Genre("Family");
            List<Genre> gensC = new List<Genre>
            {
                genC1,genC2,genC3
            };

            Media media1 = new Media
            {
                ImdbID = "tt0110357",
                Title = "The Lion King",
                Year = "1994",
                MediaType = MediaType.Movie,
                Genres = gensLK,
                ImdbRating = 8.5f,
            };
            Media media2 = new Media
            {
                ImdbID = "tt1661199",
                Title = "Cinderella",
                Year = "2015",
                MediaType = MediaType.Movie,
                Genres = gensC,
                ImdbRating = 6.9f,
            };
            mediaList.Add(media1);
            mediaList.Add(media2);
        }
    }
}
