using System;
using System.Collections.Generic;
using System.Xml.Linq;
using TallerProgramacion2020.MediaManager.IO;

namespace TallerProgramacion2020.MediaManager.IO
{
    public abstract class PersonDTO : BaseObjectDTO
    {
        protected string iFullName;

        public string FullName
        {
            get { return iFullName; }
            set { iFullName = value; }
        }

        public bool Equals(PersonDTO other)
        {
            return FullName == other.FullName;
        }
    }
}
