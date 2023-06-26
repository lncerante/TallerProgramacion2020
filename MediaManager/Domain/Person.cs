using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TallerProgramacion2020.MediaManager.Domain
{
    public abstract class Person
    {
        protected int? iID;
        protected DateTime? iITS;
        protected DateTime? iUTS;
        protected DateTime? iDTS;
        protected string iFullName;

        public Person(string pFullName)
        {
            FullName = pFullName;
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

        public string FullName
        {
            get { return iFullName; }
            set { iFullName = value; }
        }

        public bool Equals(Person other)
        {
            return FullName.ToLower().Trim() == other.FullName.ToLower().Trim();
        }
    }
}
