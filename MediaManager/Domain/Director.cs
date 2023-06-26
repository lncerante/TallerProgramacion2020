using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TallerProgramacion2020.MediaManager.Domain
{
    public class Director : Person
    {
        public Director(string pFullName) : base(pFullName) { }
        public virtual ICollection<Media> Media { get; set; }
    }
}
