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
            dataGridViewMedia.Rows.Clear();
            dataGridViewMedia.Visible = true;
            //Si alguno de los campos a buscar es distinto de vacio busco y muestro la tabla,
            //sino muestro un cartel que diga que debe compltera los campos
            if (textBoxSearchTitle.Text.Length == 0 || comboBoxGenre.Text.Length == 0 || comboBoxType.Text.Length == 0) 
            { 
                MessageBox.Show("Please enter a title to search, select a genre or / and a type", "Important!", MessageBoxButtons.OK);
            }
            else
            {                
                foreach (var media in mediaList)
                {
                    dataGridViewMedia.Rows.Add(media.ImdbID,media.Title,media.MediaType,
                        media.Genres,media.ReleaseDate,media.RuntimeInMin, media.Director,
                        media.Writer, media.Cast, media.Origin, media.ImdbRating);
                }
            }
            
        }

        private void InitializeMediaGrid()
        {
            //mediaList= la funcion buscar que tenga como parametros el tipo genero o titulo que quiere el usuario
            Media media1 = new Media
            {
                ImdbID = "5896",
                Title = "El rey leon",
                RuntimeInMin = 120
            };
            Media media2 = new Media
            {
                ImdbID = "7896",
                Title = "La cenicientan",
                RuntimeInMin = 120
            };
            mediaList.Add(media1);
            mediaList.Add(media2);
        }

        private void DataGridViewMedia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridViewMedia.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Rate")
            {
                var imdbID = dataGridViewMedia.Rows[e.RowIndex].Cells[0].Value.ToString();
                //Este id lo voy a necesitar para conectar el comentario con la pelicula
                //Tambien voy a necesitar el id del USUARIO 
                FormRateMovieOrSerie formRate = new FormRateMovieOrSerie(imdbID);
                formRate.ShowDialog();
            }
            else if (cell.Value.ToString() == "Add")
            {
                //Valido si la pelicula ya no esta en la lista del usuario, si no esta
                //muestro un mensaje de que media fue agregado de manera exitosa a su lista.
                //Tambien voy a necesitar el imbdid y el usuario
                FormMediaPriority formMediaPriority = new FormMediaPriority(); 
                formMediaPriority.ShowDialog();
                MessageBox.Show("Se agrego a su lista");
            }
            else
            {

            }
        }
    }
}
