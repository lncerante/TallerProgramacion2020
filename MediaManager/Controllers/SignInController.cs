using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;
using TallerProgramacion2020.MediaManager.ContextClass;
using TallerProgramacion2020.Forms;
using TallerProgramacion2020.MediaManager.IO;
using TallerProgramacion2020.MediaManager.Domain;
using TallerProgramacion2020.MediaManager.DAL;
using System.Linq;
using System.Net.PeerToPeer;
using System.Security.Cryptography;

namespace TallerProgramacion2020.MediaManager.Controllers
{
    /// <summary>
    /// Controlador para el inicio de sesión y registro de usuarios.
    /// </summary>
    public class SignInController
    {
        protected Context iContext;

        /// <summary>
        /// Constructor de la clase SignInController.
        /// </summary>
        public SignInController()
        {
            iContext = Context.GetInstance();
        }

        /// <summary>
        /// Verifica si existe un usuario administrador en la base de datos.
        /// </summary>
        /// <returns>True si existe un usuario administrador, False en caso contrario.</returns>
        public bool AdminExists()
        {
            Func<User, bool>[] conditions =
            {
                user => user.UserRole == UserRole.Admin
            };
            var users = iContext.UnitOfWork.UserRepository.GetWhere(conditions);
            return users.Any();
        }

        /// <summary>
        /// Registra un usuario administrador en la base de datos.
        /// </summary>
        /// <param name="pUserDTO">Los datos del usuario administrador a registrar.</param>
        /// <exception cref="Exception">Se lanzará una excepción si ocurre un error en el registro del usuario administrador.</exception>
        public void RegisterAdmin(UserDTO pUserDTO)
        {
            if (AdminExists())
            {
                throw new Exception("Admin already exists");
            }
            if (new UsersController().UserNameExists(pUserDTO.UserName))
            {
                throw new Exception("Username already in use.");
            }

            pUserDTO.UserRole = UserRole.Admin;
            User user = DTOService.FromDTO(pUserDTO);
            iContext.UnitOfWork.UserRepository.Create(user);
            iContext.UnitOfWork.Complete();
        }

        /// <summary>
        /// Realiza el inicio de sesión de un usuario.
        /// </summary>
        /// <param name="pUserName">El nombre de usuario.</param>
        /// <param name="pPassword">La contraseña del usuario.</param>
        /// <returns>Un objeto UserDTO que representa al usuario si el inicio de sesión es exitoso, o null si no es válido.</returns>
        public UserDTO SignIn(string pUserName, string pPassword)
        {
            Func<User, bool>[] conditions =
            {
                u => u.UserName == pUserName,
                u => u.PasswordHash == pPassword.GetHashCode()
            };
            var user = iContext.UnitOfWork.UserRepository.GetWhere(conditions).SingleOrDefault();

            if (user != null)
            {
                iContext.User = user;
                return DTOService.AsDTO(user);
            }
            return null;
        }
    }
}
