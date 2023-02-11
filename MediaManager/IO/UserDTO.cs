using System;

namespace TallerProgramacion2020.MediaManager.IO
{
    public class UserDTO : BaseObjectDTO
    {
        protected string iUserName;
        protected string iPassword;
        protected string iFullName;
        protected Byte[] iProfilePhoto;

        public string UserName
        {
            get { return iUserName; }
            set { iUserName = value; }
        }
        public string PasswordHash
        {
            get { return iPassword; }
            set { iPassword = value; }
        }
        public string FullName
        {
            get { return iFullName; }
            set { iFullName = value; }
        }
        public Byte[] ProfilePhoto
        {
            get { return iProfilePhoto; }
            set { iProfilePhoto = value; }
        }
    }
}
