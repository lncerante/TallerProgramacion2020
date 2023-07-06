using System;
using System.Collections.Generic;
using System.Xml.Linq;
using TallerProgramacion2020.MediaManager.IO;

namespace TallerProgramacion2020.MediaManager.IO
{
    /// <summary>
    /// Clase abstracta que representa un objeto de transferencia de datos de una persona.
    /// </summary>
    public abstract class PersonDTO : BaseObjectDTO
    {
        protected string iFullName;

        /// <summary>
        /// Nombre completo de la persona.
        /// </summary>
        public string FullName
        {
            get { return iFullName; }
            set { iFullName = value; }
        }

        /// <summary>
        /// Compara si el objeto "PersonDTO" actual es igual a otro objeto "PersonDTO".
        /// </summary>
        /// <param name="other">Otro objeto "PersonDTO" a comparar.</param>
        /// <returns>true si los nombres completos son iguales, false en caso contrario.</returns>
        public bool Equals(PersonDTO other)
        {
            return FullName == other.FullName;
        }
    }
}
