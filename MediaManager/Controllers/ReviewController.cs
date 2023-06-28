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
    public class ReviewController
    {
        protected Context iContext;

        public ReviewController()
        {
            iContext = Context.GetInstance();
        }

        public IEnumerable<ReviewDTO> GetReviews()
        {
            var reviews = iContext.UnitOfWork.ReviewRepository
                .GetAll()
                .Where(r => r.User.ID == iContext.User.ID)
                .OrderByDescending(r => r.ITS);

            return reviews.Select(review => DTOService.AsDTO(review));
        }

        public void CreateReview(int pMediaID, Rating pRating, string pComment)
        {
            Media media = iContext.UnitOfWork.MediaRepository.Get(pMediaID) ?? throw new Exception("Media could not be found.");
            var exists = iContext.UnitOfWork.ReviewRepository.GetAll()
                .Where(r => r.User.ID == iContext.User.ID && r.Media.ID == pMediaID);
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

        public void UpdateReview(int pReviewId, Rating pRating, string pComment)
        {
            Review review = iContext.UnitOfWork.ReviewRepository.Get(pReviewId) ?? throw new Exception("Review could not be found.");

            review.Rating = pRating;
            review.Comment = pComment;

            iContext.UnitOfWork.ReviewRepository.Update(review);
            iContext.UnitOfWork.Complete();
        }

        public void DeleteReview(int pReviewId)
        {
            Review review = iContext.UnitOfWork.ReviewRepository.Get(pReviewId) ?? throw new Exception("Review could not be found.");

            iContext.UnitOfWork.ReviewRepository.Delete(review);
            iContext.UnitOfWork.Complete();
        }
    }
}
