using System;
using System.Collections;
using System.Collections.Generic;

namespace TallerProgramacion2020.MediaManager.Domain
{
    /// <summary>
    /// Clase que representa un género.
    /// </summary>
    public class Genre
    {
        protected int? iID;
        protected DateTime? iITS;
        protected DateTime? iUTS;
        protected DateTime? iDTS;
        protected string iName;
        public virtual ICollection<Media> Media { get; set; }

        /// <summary>
        /// Constructor sin parámetros.
        /// </summary>
        public Genre() { }
        /// <summary>
        /// Constructor que recibe el nombre del género.
        /// </summary>
        /// <param name="pName">Nombre del género.</param>
        public Genre(string pName)
        { 
            Name = pName;
        }

        /// <summary>
        /// Id del género.
        /// </summary>
        public int? ID
        {
            get { return iID; }
            set { iID = value; }
        }

        /// <summary>
        /// Fecha de creación del género.
        /// </summary>
        public DateTime? ITS
        {
            get { return iITS; }
            set { iITS = value; }
        }

        /// <summary>
        /// Fecha de la última modificación del género.
        /// </summary>
        public DateTime? UTS
        {
            get { return iUTS; }
            set { iUTS = value; }
        }

        /// <summary>
        /// Fecha de eliminación del género.
        /// </summary>
        public DateTime? DTS
        {
            get { return iDTS; }
            set { iDTS = value; }
        }

        /// <summary>
        /// Nombre del género.
        /// </summary>
        public string Name
        {
            get { return iName; }
            set { iName = value; }
        }

        /// <summary>
        /// Compara si el nombre de este género es igual al de otro género.
        /// </summary>
        /// <param name="other">Otro género a comparar.</param>
        /// <returns>true si los nombres son iguales, false en caso contrario.</returns>
        public bool Equals(Genre other)
        {
            return Name.ToLower().Trim() == other.Name.ToLower().Trim();
        }
    }
}
