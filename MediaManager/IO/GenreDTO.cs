using System;
using System.Collections;
using System.Collections.Generic;
using TallerProgramacion2020.MediaManager.IO;

namespace TallerProgramacion2020.MediaManager.IO
{
    /// <summary>
    /// Clase que representa un objeto de transferencia de datos de un género.
    /// Hereda de la clase "BaseObjectDTO".
    /// </summary>
    public class GenreDTO : BaseObjectDTO
    {
        protected string iName;

        /// <summary>
        /// Nombre del género.
        /// </summary>
        public string Name
        {
            get { return iName; }
            set { iName = value; }
        }

        /// <summary>
        /// Compara si el nombre del género es igual al nombre de otro objeto "GenreDTO".
        /// </summary>
        public bool Equals(GenreDTO other)
        {
            return Name == other.Name;
        }
    }
}
