using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerProgramacion2020.MediaManager.Domain
{
    public class Genre : BaseObject
    {
        protected string iName;

        public string Name
        {
            get { return iName; }
            set { iName = value; }
        }
    }
}
