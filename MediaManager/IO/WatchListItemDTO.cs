using System;
using System.Collections;
using System.Collections.Generic;
using TallerProgramacion2020.MediaManager.Domain;
using TallerProgramacion2020.MediaManager.IO;

namespace TallerProgramacion2020.MediaManager.IO
{
    /// <summary>
    /// Clase que representa un objeto de transferencia de datos de un elemento de la lista de seguimiento.
    /// Hereda de la clase "BaseObjectDTO".
    /// </summary>
    public class WatchListItemDTO : BaseObjectDTO
    {
        protected string iName;
        protected UserDTO iUser;
        protected MediaDTO iMedia;
        protected Priority iPriority;

        /// <summary>
        /// Nombre del elemento de lista de seguimiento.
        /// </summary>
        public string Name
        {
            get { return iName; }
            set { iName = value; }
        }

        /// <summary>
        /// Usuario asociado al elemento de lista de seguimiento.
        /// </summary>
        public UserDTO User
        {
            get { return iUser; }
            set { iUser = value; }
        }

        /// <summary>
        /// Pelicula o serie asociada al elemento de lista de seguimiento.
        /// </summary>
        public MediaDTO Media
        {
            get { return iMedia; }
            set { iMedia = value; }
        }

        /// <summary>
        /// Prioridad del elemento de lista de seguimiento.
        /// </summary>
        public Priority Priority
        {
            get { return iPriority; }
            set { iPriority = value; }
        }
    }
}
