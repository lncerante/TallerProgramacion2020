using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerProgramacion2020.MediaManager.Domain
{
    public class User
    {
        protected int? iID;
        protected DateTime? iITS;
        protected DateTime? iUTS;
        protected DateTime? iDTS;
        protected string iUserName;
        protected int? iPasswordHash;
        protected UserRole iUserRole;
        protected string iFullName;
        protected byte[] iProfilePhoto;
        protected ICollection<Review> iReviews;
        protected ICollection<WatchListItem> iWatchListItems;

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

        public string UserName
        {
            get { return iUserName; }
            set { iUserName = value; }
        }
        public int? PasswordHash
        {
            get { return iPasswordHash; }
            set { iPasswordHash = value; }
        }
        public UserRole UserRole
        {
            get { return iUserRole; }
            set { iUserRole = value; }
        }
        public string FullName
        {
            get { return iFullName; }
            set { iFullName = value; }
        }
        public byte[] ProfilePhoto
        {
            get { return iProfilePhoto; }
            set { iProfilePhoto = value; }
        }
        public ICollection<Review> Reviews
        {
            get { return iReviews; }
            set { iReviews = value; }
        }
        public ICollection<WatchListItem> WatchListItems
        {
            get { return iWatchListItems; }
            set { iWatchListItems = value; }
        }
    }
}
