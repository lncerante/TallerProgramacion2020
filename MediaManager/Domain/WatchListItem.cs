using System;
using System.Collections.Generic;

namespace TallerProgramacion2020.MediaManager.Domain
{
    /// <summary>
    /// Clase que representa un elemento de la lista de seguimiento.
    /// </summary>
    public class WatchListItem
    {
        protected int? iID;
        protected DateTime? iITS;
        protected DateTime? iUTS;
        protected DateTime? iDTS;
        protected User iUser;
        protected Media iMedia;
        protected Priority iPriority;

        /// <summary>
        /// Id del elemento de la lista de seguimiento.
        /// </summary>
        public int? ID
        {
            get { return iID; }
            set { iID = value; }
        }

        /// <summary>
        /// Fecha de creación del elemento de la lista de seguimiento.
        /// </summary>
        public DateTime? ITS
        {
            get { return iITS; }
            set { iITS = value; }
        }

        /// <summary>
        /// Fecha de última modificación del elemento de la lista de seguimiento.
        /// </summary>
        public DateTime? UTS
        {
            get { return iUTS; }
            set { iUTS = value; }
        }

        /// <summary>
        /// Fecha de eliminación del elemento de la lista de seguimiento.
        /// </summary>
        public DateTime? DTS
        {
            get { return iDTS; }
            set { iDTS = value; }
        }

        /// <summary>
        /// Usuario asociado al elemento de la lista de seguimiento.
        /// </summary>
        public User User
        {
            get { return iUser; }
            set { iUser = value; }
        }

        /// <summary>
        /// Película o serie asociado al elemento de la lista de seguimiento.
        /// </summary>
        public Media Media
        {
            get { return iMedia; }
            set { iMedia = value; }
        }

        /// <summary>
        /// Prioridad asignada al elemento de la lista de seguimiento.
        /// </summary>
        public Priority Priority
        {
            get { return iPriority; }
            set { iPriority = value; }
        }
    }
}
