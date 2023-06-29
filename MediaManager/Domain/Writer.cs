using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TallerProgramacion2020.MediaManager.Domain
{
    public class Writer : Person
    {
        public Writer() : base() { }
        public Writer(string pFullName) : base(pFullName) { }
        public virtual ICollection<Media> Media { get; set; }
    }
}
