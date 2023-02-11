using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerProgramacion2020.MediaManager.Domain
{
    internal class BaseObject
    {
        protected int? iID;
        protected DateTime? iITS;
        protected DateTime? iUTS;
        protected DateTime? iDTS;

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
    }
}
