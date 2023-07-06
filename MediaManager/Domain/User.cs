using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerProgramacion2020.MediaManager.Domain
{
    /// <summary>
    /// Clase que representa a un usuario.
    /// </summary>
    public class User
    {
        protected int? iID;
        protected DateTime? iITS;
        protected DateTime? iUTS;
        protected DateTime? iDTS;
        protected string iUserName;
        protected int? iPasswordHash;
        protected UserRole iUserRole;
        protected string iFullName;
        protected byte[] iProfilePhoto;
        protected ICollection<Review> iReviews;
        protected ICollection<WatchListItem> iWatchListItems;

        /// <summary>
        /// ID del usuario.
        /// </summary>
        public int? ID
        {
            get { return iID; }
            set { iID = value; }
        }

        /// <summary>
        /// Fecha de creación del usuario.
        /// </summary>
        public DateTime? ITS
        {
            get { return iITS; }
            set { iITS = value; }
        }

        /// <summary>
        /// Fecha de última modificación del usuario.
        /// </summary>
        public DateTime? UTS
        {
            get { return iUTS; }
            set { iUTS = value; }
        }

        /// <summary>
        /// Fecha de eliminación del usuario.
        /// </summary>
        public DateTime? DTS
        {
            get { return iDTS; }
            set { iDTS = value; }
        }

        /// <summary>
        /// Nombre de usuario del usuario.
        /// </summary>
        public string UserName
        {
            get { return iUserName; }
            set { iUserName = value; }
        }

        /// <summary>
        /// Hash de la contraseña del usuario.
        /// </summary>
        public int? PasswordHash
        {
            get { return iPasswordHash; }
            set { iPasswordHash = value; }
        }

        /// <summary>
        /// Rol del usuario.
        /// </summary>
        public UserRole UserRole
        {
            get { return iUserRole; }
            set { iUserRole = value; }
        }

        /// <summary>
        /// Nombre completo del usuario.
        /// </summary>
        public string FullName
        {
            get { return iFullName; }
            set { iFullName = value; }
        }

        /// <summary>
        /// Foto de perfil del usuario en formato de bytes.
        /// </summary>
        public byte[] ProfilePhoto
        {
            get { return iProfilePhoto; }
            set { iProfilePhoto = value; }
        }

        /// <summary>
        /// Colección de las críticas realizadas por el usuario.
        /// </summary>
        public ICollection<Review> Reviews
        {
            get { return iReviews; }
            set { iReviews = value; }
        }

        /// <summary>
        /// Colección de los elementos de la lista de seguimiento del usuario.
        /// </summary>
        public ICollection<WatchListItem> WatchListItems
        {
            get { return iWatchListItems; }
            set { iWatchListItems = value; }
        }
    }
}
