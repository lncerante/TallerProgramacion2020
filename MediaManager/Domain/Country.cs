using System;
using System.Collections.Generic;

namespace TallerProgramacion2020.MediaManager.Domain
{
    /// <summary>
    /// Clase que representa un país.
    /// </summary>
    public class Country
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
        public Country() { }
        /// <summary>
        /// Constructor que recibe el nombre del país.
        /// </summary>
        /// <param name="pName">Nombre del país.</param>
        public Country(string pName)
        {
            Name = pName;
        }

        /// <summary>
        /// Id del país.
        /// </summary>
        public int? ID
        {
            get { return iID; }
            set { iID = value; }
        }

        /// <summary>
        /// Fecha de creación del país.
        /// </summary>
        public DateTime? ITS
        {
            get { return iITS; }
            set { iITS = value; }
        }

        /// <summary>
        /// Fecha de última modificación del país.
        /// </summary>
        public DateTime? UTS
        {
            get { return iUTS; }
            set { iUTS = value; }
        }

        /// <summary>
        /// Fecha de eliminación del país.
        /// </summary>
        public DateTime? DTS
        {
            get { return iDTS; }
            set { iDTS = value; }
        }

        /// <summary>
        /// Nombre del país.
        /// </summary>
        public string Name
        {
            get { return iName; }
            set { iName = value; }
        }

        /// <summary>
        /// Compara si el nombre de este país es igual al de otro país.
        /// </summary>
        /// <param name="other">Otro país a comparar.</param>
        /// <returns>true si los nombres son iguales, false en caso contrario.</returns>
        public bool Equals(Country other)
        {
            return Name.ToLower().Trim() == other.Name.ToLower().Trim();
        }
    }
}
