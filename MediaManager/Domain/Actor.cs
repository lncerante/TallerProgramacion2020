using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TallerProgramacion2020.MediaManager.Domain
{
    internal class Actor : Person
    {
        public Actor(string pFullName) : base(pFullName) { }
        public virtual ICollection<Media> Media { get; set; }
    }
}
