using System;
using System.Collections;
using System.Collections.Generic;
using TallerProgramacion2020.MediaManager.Domain;
using TallerProgramacion2020.MediaManager.IO;

namespace TallerProgramacion2020.MediaManager.IO
{
    public class ReviewDTO : BaseObjectDTO
    {
        protected string iName;
        protected UserDTO iUser;
        protected MediaDTO iMedia;
        protected Rating iRating;
        protected string iComment;

        public string Name
        {
            get { return iName; }
            set { iName = value; }
        }

        public UserDTO User
        {
            get { return iUser; }
            set { iUser = value; }
        }

        public MediaDTO Media
        {
            get { return iMedia; }
            set { iMedia = value; }
        }

        public Rating Rating
        {
            get { return iRating; }
            set { iRating = value; }
        }

        public string Comment
        {
            get { return iComment; }
            set { iComment = value; }
        }
    }
}
