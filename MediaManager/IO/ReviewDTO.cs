using System;
using System.Collections;
using System.Collections.Generic;
using TallerProgramacion2020.MediaManager.Domain;
using TallerProgramacion2020.MediaManager.IO;

namespace TallerProgramacion2020.MediaManager.IO
{
    /// <summary>
    /// Clase que representa un objeto de transferencia de datos de una reseña.
    /// Hereda de la clase "BaseObjectDTO".
    /// </summary>
    public class ReviewDTO : BaseObjectDTO
    {
        protected string iName;
        protected UserDTO iUser;
        protected MediaDTO iMedia;
        protected Rating iRating;
        protected string iComment;

        /// <summary>
        /// Nombre de la reseña.
        /// </summary>
        public string Name
        {
            get { return iName; }
            set { iName = value; }
        }

        /// <summary>
        /// Usuario asociado a la reseña.
        /// </summary>
        public UserDTO User
        {
            get { return iUser; }
            set { iUser = value; }
        }

        /// <summary>
        /// Película o serie asociado a la reseña.
        /// </summary>
        public MediaDTO Media
        {
            get { return iMedia; }
            set { iMedia = value; }
        }

        /// <summary>
        /// Calificación de la reseña.
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
