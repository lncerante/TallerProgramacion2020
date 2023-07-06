using System;
using System.Collections.Generic;

namespace TallerProgramacion2020.MediaManager.IO
{
    /// <summary>
    /// Clase que representa un objeto de transferencia de datos de un país.
    /// Hereda de la clase "BaseObjectDTO".
    /// </summary>
    public class CountryDTO : BaseObjectDTO
    {
        protected string iName;

        /// <summary>
        /// Nombre del país.
        /// </summary>
        public string Name
        {
            get { return iName; }
            set { iName = value; }
        }

        /// <summary>
        /// Compara si el nombre del país es igual al nombre de otro objeto "CountryDTO".
        /// </summary>
        public bool Equals(CountryDTO other)
        {
            return Name == other.Name;
        }
    }
}
