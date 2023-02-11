using System;

namespace TallerProgramacion2020.MediaManager.IO
{
    public class BaseObjectDTO
    {
        protected int? iID;
        protected DateTime? iITS;
        protected DateTime? iUTS;

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
    }
}
