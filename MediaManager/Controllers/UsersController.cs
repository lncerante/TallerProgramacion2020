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

namespace TallerProgramacion2020.MediaManager.Controllers
{
    /// <summary>
    /// Controlador para la gestión de usuarios.
    /// </summary>
    public class UsersController
    {
        protected Context iContext;

        /// <summary>
        /// Constructor de la clase UsersController.
        /// </summary>
        public UsersController()
        {
            iContext = Context.GetInstance();
        }

        /// <summary>
        /// Verifica si existe un nombre de usuario en la base de datos, excluyendo un ID específico.
        /// </summary>
        /// <param name="pUserName">El nombre de usuario a verificar.</param>
        /// <param name="pId">El ID del usuario a excluir de la verificación. (Opcional)</param>
        /// <returns>True si el nombre de usuario existe y no coincide con el ID proporcionado, False en caso contrario.</returns>
        public bool UserNameExists(string pUserName, int? pId = null)
        {
            var users = iContext.UnitOfWork.UserRepository.GetAll();
            return users.Any(user => user.UserName == pUserName && user.ID != pId);
        }

        /// <summary>
        /// Obtiene una lista de todos los usuarios registrados.
        /// </summary>
        /// <returns>Una colección de UserDTO que representa a los usuarios.</returns>
        /// <exception cref="Exception">Se lanzará una excepción si el usuario actual no tiene permiso de administrador.</exception>
        public IEnumerable<UserDTO> GetUsers()
        {
            if (iContext.User.UserRole != UserRole.Admin)
            {
                throw new Exception("Permission denied.");
            }
            var users = iContext.UnitOfWork.UserRepository.GetAll();

            return users.Select(user => DTOService.AsDTO(user));
        }

        /// <summary>
        /// Crea un nuevo usuario.
        /// </summary>
        /// <param name="pUserDTO">Los datos del usuario a crear.</param>
        /// <exception cref="Exception">Se lanzará una excepción si el usuario actual no
        /// tiene permiso de administrador o si el nombre de usuario ya está en uso.</exception>
        public void CreateUser(UserDTO pUserDTO)
        {
            if (iContext.User.UserRole != UserRole.Admin)
            {
                throw new Exception("Permission denied.");
            }
            if (UserNameExists(pUserDTO.UserName))
            {
                throw new Exception("Username already in use.");
            }
            User user = DTOService.FromDTO(pUserDTO);

            iContext.UnitOfWork.UserRepository.Create(user);
            iContext.UnitOfWork.Complete();
        }

        /// <summary>
        /// Actualiza los datos de un usuario existente.
        /// </summary>
        /// <param name="pUserDTO">Los nuevos datos del usuario.</param>
        /// <exception cref="Exception">Se lanzará una excepción si el usuario actual no tiene permiso
        /// de administrador, si no se proporciona un ID de usuario o si el nombre de usuario ya está
        /// en uso.</exception>
        public void UpdateUser(UserDTO pUserDTO)
        {
            if (iContext.User.UserRole != UserRole.Admin)
            {
                throw new Exception("Permission denied.");
            }
            if (pUserDTO.ID == null)
            {
                throw new Exception("User ID was not provided.");
            }
            if (UserNameExists(pUserDTO.UserName, pUserDTO.ID))
            {
                throw new Exception("Username already in use.");
            }
            User user = DTOService.FromDTO(pUserDTO);

            iContext.UnitOfWork.UserRepository.Update(user);
            iContext.UnitOfWork.Complete();
        }

        /// <summary>
        /// Elimina un usuario existente.
        /// </summary>
        /// <param name="pUserId">El ID del usuario a eliminar.</param>
        /// <exception cref="Exception">Se lanzará una excepción si el usuario actual no tiene 
        /// permiso de administrador o si intenta eliminar su propio usuario.</exception>
        public void DeleteUser(int pUserId)
        {
            if (iContext.User.UserRole != UserRole.Admin)
            {
                throw new Exception("Permission denied.");
            }
            if (iContext.User.ID == pUserId)
            {
                throw new Exception("You cannot delete your own user.");
            }

            User user = iContext.UnitOfWork.UserRepository.Get(pUserId) ?? throw new Exception("User could not be found.");

            iContext.UnitOfWork.UserRepository.Delete(user);
            iContext.UnitOfWork.Complete();
        }
    }
}
