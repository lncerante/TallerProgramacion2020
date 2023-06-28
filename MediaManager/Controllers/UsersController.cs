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
    public class UsersController
    {
        protected Context iContext;

        public UsersController()
        {
            iContext = Context.GetInstance();
        }

        public bool UserNameExists(string pUserName, int? pId = null)
        {
            var users = iContext.UnitOfWork.UserRepository.GetAll();
            return users.Any(user => user.UserName == pUserName && user.ID != pId);
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            if (iContext.User.UserRole != UserRole.Admin)
            {
                throw new Exception("Permission denied.");
            }
            var users = iContext.UnitOfWork.UserRepository.GetAll();

            return users.Select(user => DTOService.AsDTO(user));
        }

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
