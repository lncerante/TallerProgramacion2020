using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerProgramacion2020.MediaManager.IO;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.Forms
{
    public partial class FormReviews : Form
    {
        private List<MediaDTO> mediaList;
        public FormReviews()
        {
            InitializeComponent();
        }

        private void FormReviews_Load(object sender, EventArgs e)
        {
            InitializeReviews();
            //List<string> mediaList = controlador.Reviews(iduser)
            if(mediaList != null)
            {
                buttonEdit.Visible = true;
                foreach (var media in mediaList)
                {
                    dataGridViewMedia.Rows.Add(media.ImdbID, media.Title, media.Year, media.MediaType, "Terrible",
                        "Muy buen la peli, me gusto muuuuuuuuuuuuuuuuuuuuuuuuuuucho"
                    );
                }
            }
        }

        //eliminar despues
        private void InitializeReviews()
        {
            MediaDTO media1 = new MediaDTO
            {
                ImdbID = "tt0088939",
                Title = "The Color Purple",
                Year = "1985",
                MediaType = MediaType.Movie,
            };
            var media = new List<MediaDTO>
            {
                media1, media1, media1, media1, media1
            };
            mediaList = media;
            
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedia.SelectedRows.Count == 1)
            {
                var idIMDB = dataGridViewMedia.CurrentRow.Cells["ColumnImdbID"].Value.ToString();
                FormRateMovieOrSeries formRateMoviesOrSeries = new FormRateMovieOrSeries(idIMDB);
                formRateMoviesOrSeries.ShowDialog();
            }
        }
    }
}
