using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TallerProgramacion2020.MediaManager.Domain
{
    /// <summary>
    /// Clase abstracta que representa a una persona.
    /// </summary>
    public abstract class Person
    {
        protected int? iID;
        protected DateTime? iITS;
        protected DateTime? iUTS;
        protected DateTime? iDTS;
        protected string iFullName;

        /// <summary>
        /// Constructor por defecto de la clase "Person".
        /// </summary>
        public Person() { }
        /// <summary>
        /// Constructor de la clase "Person" que establece el nombre completo de la persona.
        /// </summary>
        /// <param name="pFullName">Nombre completo de la persona.</param>
        public Person(string pFullName)
        {
            FullName = pFullName;
        }

        /// <summary>
        /// ID de la persona.
        /// </summary>
        public int? ID
        {
            get { return iID; }
            set { iID = value; }
        }

        /// <summary>
        /// Fecha de creación de la persona.
        /// </summary>
        public DateTime? ITS
        {
            get { return iITS; }
            set { iITS = value; }
        }

        /// <summary>
        /// Fecha de última modificación de la persona.
        /// </summary>
        public DateTime? UTS
        {
            get { return iUTS; }
            set { iUTS = value; }
        }

        /// <summary>
        /// Fecha de eliminación de la persona.
        /// </summary>
        public DateTime? DTS
        {
            get { return iDTS; }
            set { iDTS = value; }
        }

        /// <summary>
        /// Nombre completo de la persona.
        /// </summary>
        public string FullName
        {
            get { return iFullName; }
            set { iFullName = value; }
        }

        /// <summary>
        /// Compara si la persona es igual a otra persona.
        /// </summary>
        /// <param name="other">Otra persona a comparar.</param>
        /// <returns>true si las personas tienen el mismo nombre completo (ignorando mayúsculas y espacios en blanco), false en caso contrario.</returns>
        public bool Equals(Person other)
        {
            return FullName.ToLower().Trim() == other.FullName.ToLower().Trim();
        }
    }
}
