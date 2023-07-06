using System;
using System.Collections.Generic;

namespace TallerProgramacion2020.MediaManager.Domain
{
    /// <summary>
    /// Clase que representa una reseña.
    /// </summary>
    public class Review
    {
        protected int? iID;
        protected DateTime? iITS;
        protected DateTime? iUTS;
        protected DateTime? iDTS;
        protected User iUser;
        protected Media iMedia;
        protected Rating iRating;
        protected string iComment;

        /// <summary>
        /// Id de la reseña.
        /// </summary>
        public int? ID
        {
            get { return iID; }
            set { iID = value; }
        }

        /// <summary>
        /// Fecha de creación de la reseña.
        /// </summary>
        public DateTime? ITS
        {
            get { return iITS; }
            set { iITS = value; }
        }

        /// <summary>
        /// Fecha de la última modifiación de la reseña.
        /// </summary>
        public DateTime? UTS
        {
            get { return iUTS; }
            set { iUTS = value; }
        }

        /// <summary>
        /// Fecha de eliminación de la reseña.
        /// </summary>
        public DateTime? DTS
        {
            get { return iDTS; }
            set { iDTS = value; }
        }

        /// <summary>
        /// Usuario que realizó la reseña.
        /// </summary>
        public User User
        {
            get { return iUser; }
            set { iUser = value; }
        }

        /// <summary>
        /// Película o serie asociada a la reseña.
        /// </summary>
        public Media Media
        {
            get { return iMedia; }
            set { iMedia = value; }
        }

        /// <summary>
        /// Calificación asignada a la reseña.
        /// </summary>
        public Rating Rating
        {
            get { return iRating; }
            set { iRating = value; }
        }

        /// <summary>
        /// Comentario de la reseña.
        /// </summary>
        public string Comment
        {
            get { return iComment; }
            set { iComment = value; }
        }
    }
}
