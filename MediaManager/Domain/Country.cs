using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerProgramacion2020.MediaManager.Domain
{
    internal class Country : BaseObject
    {
        protected string iName;

        public string Name
        {
            get { return iName; }
            set { iName = value; }
        }
    }
}
