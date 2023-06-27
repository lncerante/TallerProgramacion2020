using System;
using System.Collections.Generic;

namespace TallerProgramacion2020.MediaManager.Domain
{
    public class WatchListItem
    {
        protected int? iID;
        protected DateTime? iITS;
        protected DateTime? iUTS;
        protected DateTime? iDTS;
        protected User iUser;
        protected Media iMedia;
        protected Priority iPriority;

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

        public User User
        {
            get { return iUser; }
            set { iUser = value; }
        }

        public Media Media
        {
            get { return iMedia; }
            set { iMedia = value; }
        }

        public Priority Priority
        {
            get { return iPriority; }
            set { iPriority = value; }
        }
    }
}
