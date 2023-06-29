using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.MediaManager.DAL.EntityFramework
{
    internal class ReviewRepository : Repository<Review, MediaManagerDbContext>, IReviewRepository
    {

        public ReviewRepository(MediaManagerDbContext pContext) : base(pContext) { }

        public override void Create(Review pReview)
        {
            Media media = iDbContext.Media.Find(pReview.Media.ID) ?? throw new Exception("Media could not be found.");
            User user = iDbContext.Users.Find(pReview.User.ID) ?? throw new Exception("User could not be found.");
            pReview.ITS = DateTime.Now;
            iDbContext.Reviews.Add(pReview);
        }

        public override void Update(Review pReview)
        {
            var review = iDbContext.Reviews.Find(pReview.ID) ?? throw new Exception("Review could not be found.");
            review.UTS = DateTime.Now;
            review.Rating = pReview.Rating;
            review.Comment = pReview.Comment != null ? pReview.Comment : review.Comment;
        }

        public override void Delete(Review pReview)
        {
            iDbContext.Reviews.Remove(pReview);
        }

        public override Review Get(int pId)
        {
            return iDbContext.Reviews.Find(pId);
        }

        public override IEnumerable<Review> GetAll()
        {
            return iDbContext.Reviews
                .Include("User")
                .Include("Media")
                .Include("Media.Genres")
                .Include("Media.Origin")
                .Include("Media.Cast")
                .Include("Media.Director")
                .Include("Media.Writer");
        }
    }
}
