using System;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.MediaManager.IO
{
    public class UserDTO : BaseObjectDTO
    {
        protected string iUserName;
        protected string iPassword;
        protected string iFullName;
        protected byte[] iProfilePhoto;
        protected UserRole iUserRole;

        public string UserName
        {
            get { return iUserName; }
            set { iUserName = value; }
        }
        public string Password
        {
            get { return iPassword; }
            set { iPassword = value; }
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
        public UserRole UserRole
        {
            get { return iUserRole; }
            set { iUserRole = value; }
        }
    }
}
