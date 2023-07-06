using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TallerProgramacion2020.MediaManager.Domain
{
    /// <summary>
    /// Clase que representa un director.
    /// </summary>
    public class Director : Person
    {
        /// <summary>
        /// Constructor sin parámetros.
        /// </summary>
        public Director() : base() { }
        /// <summary>
        /// Constructor que recibe el nombre completo del director.
        /// </summary>
        /// <param name="pFullName">Nombre completo del director.</param>
        public Director(string pFullName) : base(pFullName) { }
        /// <summary>
        /// Colección de películas y/o series asociadas al director.
        /// </summary>
        public virtual ICollection<Media> Media { get; set; }
    }
}
