using System;
using System.Collections.Generic;

namespace TallerProgramacion2020.MediaManager.IO
{
    public class CountryDTO : BaseObjectDTO
    {
        protected string iName;

        public string Name
        {
            get { return iName; }
            set { iName = value; }
        }

        public bool Equals(CountryDTO other)
        {
            return Name == other.Name;
        }
    }
}
