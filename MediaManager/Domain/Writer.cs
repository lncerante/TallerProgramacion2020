using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TallerProgramacion2020.MediaManager.Domain
{
    /// <summary>
    /// Clase que representa un escritor.
    /// </summary>
    public class Writer : Person
    {
        /// <summary>
        /// Constructor por defecto de la clase Writer.
        /// </summary>
        public Writer() : base() { }
        /// <summary>
        /// Constructor de la clase Writer que recibe el nombre completo del escritor.
        /// </summary>
        /// <param name="pFullName">Nombre completo del escritor.</param>
        public Writer(string pFullName) : base(pFullName) { }
        /// <summary>
        /// Colección virtual de peliculas y series asociados al escritor.
        /// </summary>
        public virtual ICollection<Media> Media { get; set; }
    }
}
