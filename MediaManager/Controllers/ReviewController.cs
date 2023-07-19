using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;
using TallerProgramacion2020.MediaManager.ContextClass;
using TallerProgramacion2020.Forms;
using TallerProgramacion2020.MediaManager.IO;
using TallerProgramacion2020.MediaManager.Domain;
using TallerProgramacion2020.MediaManager.DAL;
using System.Linq;

namespace TallerProgramacion2020.MediaManager.Controllers
{
    /// <summary>
    /// Controlador para la gestión de reseñas.
    /// </summary>
    public class ReviewController
    {
        protected Context iContext;

        /// <summary>
        /// Constructor de la clase ReviewController.
        /// </summary>
        public ReviewController()
        {
            iContext = Context.GetInstance();
        }

        /// <summary>
        /// Obtiene las reseñas del usuario actual.
        /// </summary>
        /// <returns>Una colección de objetos ReviewDTO que representan las reseñas del usuario.</returns>
        public IEnumerable<ReviewDTO> GetReviews()
        {
            Func<Review, bool>[] conditions =
            {
                r => r.User.ID == iContext.User.ID
            };
            var reviews = iContext.UnitOfWork.ReviewRepository
                .GetWhere(conditions)
                .OrderByDescending(r => r.ITS);

            return reviews.Select(review => DTOService.AsDTO(review));
        }

        /// <summary>
        /// Crea una nueva reseña.
        /// </summary>
        /// <param name="pMediaID">El ID de la media a la que se hace la reseña.</param>
        /// <param name="pRating">La calificación de la reseña.</param>
        /// <param name="pComment">El comentario de la reseña.</param>
        /// <exception cref="Exception">Se lanzará una excepción si ocurre un error en la creación de la reseña.</exception>
        public void CreateReview(int pMediaID, Rating pRating, string pComment)
        {
            Media media = iContext.UnitOfWork.MediaRepository.Get(pMediaID) ?? throw new Exception("Media could not be found.");

            Func<Review, bool>[] conditions =
            {
                r => r.User.ID == iContext.User.ID,
                r => r.Media.ID == pMediaID
            };
            var exists = iContext.UnitOfWork.ReviewRepository.GetWhere(conditions);

            if (exists.Count() > 0)
            {
                throw new Exception("You have already reviewd this media.");
            }

            Review review = new Review
            {
                User = iContext.User,
                Media = media,
                Rating = pRating,
                Comment = pComment
            };

            iContext.UnitOfWork.ReviewRepository.Create(review);
            iContext.UnitOfWork.Complete();
        }

        /// <summary>
        /// Actualiza una reseña existente.
        /// </summary>
        /// <param name="pReviewId">El ID de la reseña a actualizar.</param>
        /// <param name="pRating">La nueva calificación de la reseña.</param>
        /// <param name="pComment">El nuevo comentario de la reseña.</param>
        /// <exception cref="Exception">Se lanzará una excepción si ocurre un error en la actualización de la reseña.</exception>
        public void UpdateReview(int pReviewId, Rating pRating, string pComment)
        {
            Review review = iContext.UnitOfWork.ReviewRepository.Get(pReviewId) ?? throw new Exception("Review could not be found.");

            review.Rating = pRating;
            review.Comment = pComment;

            iContext.UnitOfWork.ReviewRepository.Update(review);
            iContext.UnitOfWork.Complete();
        }

        /// <summary>
        /// Elimina una reseña existente.
        /// </summary>
        /// <param name="pReviewId">El ID de la reseña a eliminar.</param>
        /// <exception cref="Exception">Se lanzará una excepción si ocurre un error en la eliminación de la reseña.</exception>
        public void DeleteReview(int pReviewId)
        {
            Review review = iContext.UnitOfWork.ReviewRepository.Get(pReviewId) ?? throw new Exception("Review could not be found.");

            iContext.UnitOfWork.ReviewRepository.Delete(review);
            iContext.UnitOfWork.Complete();
        }
    }
}
