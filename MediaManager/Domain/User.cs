using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerProgramacion2020.MediaManager.Domain
{
    internal class User : BaseObject
    {
        protected string iUserName;
        protected string iPasswordHash;
        protected IList<UserRole> iUserRoles;
        protected string iFullName;
        protected Byte[] iProfilePhoto;

        public string UserName
        {
            get { return iUserName; }
            set { iUserName = value; }
        }
        public string PasswordHash
        {
            get { return iPasswordHash; }
            set { iPasswordHash = value; }
        }
        public IList<UserRole> UserRoles
        {
            get { return iUserRoles; }
            set { iUserRoles = value; }
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
