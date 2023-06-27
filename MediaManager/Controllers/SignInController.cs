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
    public class SignInController
    {
        protected Context iContext;

        public SignInController()
        {
            iContext = Context.GetInstance();
        }

        protected bool AdminExists()
        {
            var users = iContext.UnitOfWork.UserRepository.GetAll();
            return users.Any(user => user.UserRole == UserRole.Admin);
        }

        public void Run()
        {
            if (!AdminExists())
            {
                Application.Run(new FormRegisterAdminUser());
            }
            else
            {
                Application.Run(new FormSignIn());
            }
        }

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

        public UserDTO SignIn(string pUserName, string pPassword)
        {
            var users = iContext.UnitOfWork.UserRepository.GetAll();
            var user = users.SingleOrDefault(
                u => u.UserName == pUserName && 
                u.PasswordHash == pPassword.GetHashCode()
            );

            if (user != null)
            {
                iContext.User = user;
                return DTOService.AsDTO(user);
            }
            return null;
        }
    }
}
