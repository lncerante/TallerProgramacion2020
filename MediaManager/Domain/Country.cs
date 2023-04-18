using System;
using System.Collections.Generic;

namespace TallerProgramacion2020.MediaManager.Domain
{
    internal class Country
    {
        protected int? iID;
        protected DateTime? iITS;
        protected DateTime? iUTS;
        protected DateTime? iDTS;
        protected string iName;
        public virtual ICollection<Media> Media { get; set; }

        public Country(string pName)
        {
            Name = pName;
        }

        public int? ID
        {
            get { return iID; }
            set { iID = value; }
        }

        public DateTime? ITS
        {
            get { return iITS; }
            set { iITS = value; }
        }

        public DateTime? UTS
        {
            get { return iUTS; }
            set { iUTS = value; }
        }

        public DateTime? DTS
        {
            get { return iDTS; }
            set { iDTS = value; }
        }

        public string Name
        {
            get { return iName; }
            set { iName = value; }
        }

        public bool Equals(Country other)
        {
            return Name == other.Name;
        }
    }
}
