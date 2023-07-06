using System;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.MediaManager.IO
{
    /// <summary>
    /// Clase que representa un objeto de transferencia de datos de un usuario.
    /// </summary>
    public class UserDTO : BaseObjectDTO
    {
        protected string iUserName;
        protected string iPassword;
        protected string iFullName;
        protected byte[] iProfilePhoto;
        protected UserRole iUserRole;

        /// <summary>
        /// Nombre de usuario del usuario.
        /// </summary>
        public string UserName
        {
            get { return iUserName; }
            set { iUserName = value; }
        }

        /// <summary>
        /// Contraseña del usuario.
        /// </summary>
        public string Password
        {
            get { return iPassword; }
            set { iPassword = value; }
        }

        /// <summary>
        /// Nombre completo del usuario.
        /// </summary>
        public string FullName
        {
            get { return iFullName; }
            set { iFullName = value; }
        }

        /// <summary>
        /// Foto de perfil del usuario.
        /// </summary>
        public byte[] ProfilePhoto
        {
            get { return iProfilePhoto; }
            set { iProfilePhoto = value; }
        }

        /// <summary>
        /// Rol del usuario.
        /// </summary>
        public UserRole UserRole
        {
            get { return iUserRole; }
            set { iUserRole = value; }
        }
    }
}
