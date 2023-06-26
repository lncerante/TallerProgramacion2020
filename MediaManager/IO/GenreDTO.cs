using System;
using System.Collections;
using System.Collections.Generic;
using TallerProgramacion2020.MediaManager.IO;

namespace TallerProgramacion2020.MediaManager.IO
{
    public class GenreDTO : BaseObjectDTO
    {
        protected string iName;

        public string Name
        {
            get { return iName; }
            set { iName = value; }
        }

        public bool Equals(GenreDTO other)
        {
            return Name == other.Name;
        }
    }
}
