using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerProgramacion2020.MediaManager.Domain
{
    internal class Person : BaseObject
    {
        protected string iFullName;

        public string FullName
        {
            get { return iFullName; }
            set { iFullName = value; }
        }
    }
}
