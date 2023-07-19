using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.MediaManager.DAL.EntityFramework
{
    /// <summary>
    /// Clase interna que hereda de Repository y representa el repositorio para la entidad Review.
    /// Proporciona métodos para realizar operaciones de creación, actualización, eliminación y consulta en la base de datos.
    /// </summary>
    internal class ReviewRepository : Repository<Review, MediaManagerDbContext>, IReviewRepository
    {
        /// <summary>
        /// Constructor de la clase ReviewRepository.
        /// </summary>
        /// <param name="pContext">Instancia del contexto de base de datos.</param>
        public ReviewRepository(MediaManagerDbContext pContext) : base(pContext) { }

        /// <summary>
        /// Crea una nueva reseña en la base de datos.
        /// </summary>
        /// <param name="pReview">Reseña a crear.</param>
        public override void Create(Review pReview)
        {
            Media media = iDbContext.Media.Find(pReview.Media.ID) ?? throw new Exception("Media could not be found.");
            User user = iDbContext.Users.Find(pReview.User.ID) ?? throw new Exception("User could not be found.");
            pReview.ITS = DateTime.Now;
            iDbContext.Reviews.Add(pReview);
        }

        /// <summary>
        /// Actualiza una reseña existente en la base de datos.
        /// </summary>
        /// <param name="pReview">Reseña a actualizar.</param>
        public override void Update(Review pReview)
        {
            var review = iDbContext.Reviews.Find(pReview.ID) ?? throw new Exception("Review could not be found.");
            review.UTS = DateTime.Now;
            review.Rating = pReview.Rating;
            review.Comment = pReview.Comment != null ? pReview.Comment : review.Comment;
        }

        /// <summary>
        /// Elimina una reseña existente de la base de datos.
        /// </summary>
        /// <param name="pReview">Reseña a eliminar.</param>
        public override void Delete(Review pReview)
        {
            iDbContext.Reviews.Remove(pReview);
        }

        /// <summary>
        /// Obtiene una reseña de la base de datos según su identificador.
        /// </summary>
        /// <param name="pId">Identificador de la reseña.</param>
        /// <returns>Reseña encontrada o null si no se encuentra.</returns>
        public override Review Get(int pId)
        {
            return iDbContext.Reviews.Find(pId);
        }

        /// <summary>
        /// Obtiene todas las reseñas de la base de datos.
        /// </summary>
        /// <returns>Enumeración de reseñas.</returns>
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

        /// <summary>
        /// Obtiene todas las Medias de la base de datos que cumplen con un listado de condiciones.
        /// </summary>
        /// <param name="pConditions">Listado de condiciones.</param>
        /// <returns>Enumeración de medias que cumplen con un listado de condiciones.</returns>
        public override IEnumerable<Review> GetWhere(IEnumerable<Func<Review, bool>> pConditions)
        {
            return iDbContext.Reviews
                .Include("User")
                .Include("Media")
                .Include("Media.Genres")
                .Include("Media.Origin")
                .Include("Media.Cast")
                .Include("Media.Director")
                .Include("Media.Writer")
                .AsEnumerable()
                .Where(review => pConditions.All(condition => condition(review)));
        }
    }
}
