using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TallerProgramacion2020.MediaManager.Domain
{
    /// <summary>
    /// Clase que representa a un actor.
    /// Hereda de la clase base "Person".
    /// </summary>
    public class Actor : Person
    {
        /// <summary>
        /// Constructor sin parámetros.
        /// </summary>
        public Actor() : base() { }
        /// <summary>
        /// Constructor que recibe el nombre completo del actor.
        /// </summary>
        /// <param name="pFullName">Nombre completo del actor.</param>
        public Actor(string pFullName) : base(pFullName) { }
        /// <summary>
        /// Colección virtual de peliculas y series asociados al actor.
        /// </summary>
        public virtual ICollection<Media> Media { get; set; }
    }
}
