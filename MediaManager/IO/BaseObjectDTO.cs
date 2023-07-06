using System;

namespace TallerProgramacion2020.MediaManager.IO
{
    /// <summary>
    /// Clase base que representa un objeto de transferencia de datos.
    /// </summary>
    public class BaseObjectDTO
    {
        protected int? iID;
        protected DateTime? iITS;
        protected DateTime? iUTS;

        /// <summary>
        /// Identificador del objeto.
        /// </summary>
        public int? ID
        {
            get { return iID; }
            set { iID = value; }
        }

        /// <summary>
        /// Fecha de creación del objeto.
        /// </summary>
        public DateTime? ITS
        {
            get { return iITS; }
            set { iITS = value; }
        }

        /// <summary>
        /// Fecha de última modificación del objeto.
        /// </summary>
        public DateTime? UTS
        {
            get { return iUTS; }
            set { iUTS = value; }
        }
    }
}
