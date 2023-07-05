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
using TallerProgramacion2020.MediaManager.Controllers;

namespace TallerProgramacion2020.Forms
{
    public partial class FormReviews : Form
    {
        private IEnumerable<ReviewDTO> reviewList;

        /// <summary>
        /// Formulario que permite vizualizar todas las reseñas de un usuario.
        /// </summary>
        public FormReviews()
        {
            InitializeComponent();
        }

        private void FormReviews_Load(object sender, EventArgs e)
        {
            GetReviews();
        }

        /// <summary>
        /// Obtiene y muestra todas las reseñas de un usuario.
        /// </summary>
        private void GetReviews()
        {
            try
            {
                reviewList = new ReviewController().GetReviews();
                if (reviewList != null)
                {
                    dataGridViewMedia.Rows.Clear();
                    buttonEdit.Visible = true;
                    foreach (var review in reviewList)
                    {
                        dataGridViewMedia.Rows.Add
                        (
                            review.Media.ImdbID,
                            review.Media.Title,
                            review.Media.Year,
                            review.Media.MediaType,
                            review.Rating.ToString(),
                            review.Comment,
                            review.ITS?.ToShortDateString()
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Permite editar una reseña.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedia.SelectedRows.Count == 1)
            {
                var idIMDB = dataGridViewMedia.CurrentRow.Cells["ColumnImdbID"].Value.ToString();
                var review = reviewList.FirstOrDefault(r => r.Media.ImdbID == idIMDB);
                if (review != null && review.Media.ID != null)
                {
                    FormRateMovieOrSeries formRateMovieOrSeries = new FormRateMovieOrSeries((int)review.Media.ID, review);
                    formRateMovieOrSeries.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error trying to open review.");
                }
                GetReviews();
            }
        }

        /// <summary>
        /// Elimina una reseña.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedia.SelectedRows.Count == 1)
            {
                var idIMDB = dataGridViewMedia.CurrentRow.Cells["ColumnImdbID"].Value.ToString();
                var review = reviewList.FirstOrDefault(r => r.Media.ImdbID == idIMDB);
                if (review != null && review.ID != null)
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this review?", "Delete review", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            new ReviewController().DeleteReview((int)review.ID);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a review to delete.");
                }
                GetReviews();
            }
        }
    }
}
