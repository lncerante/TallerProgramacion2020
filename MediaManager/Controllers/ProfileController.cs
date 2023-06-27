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
    public class ProfileController
    {
        protected Context iContext;

        public ProfileController()
        {
            iContext = Context.GetInstance();
        }

        public void UpdateUser(UserDTO pUserDTO, string pOldPassword)
        {
            if (pUserDTO.ID != iContext.User.ID)
            {
                throw new Exception("You cannot update another user.");
            }
            if (new UsersController().UserNameExists(pUserDTO.UserName, pUserDTO.ID))
            {
                throw new Exception("Username already in use.");
            }
            if (!string.IsNullOrEmpty(pUserDTO.Password) && pOldPassword.GetHashCode() != iContext.User.PasswordHash)
            {
                throw new Exception("Wrong password.");
            }
            User user = DTOService.FromDTOToUser(pUserDTO, iContext.User);
            iContext.UnitOfWork.UserRepository.Update(user);
            iContext.UnitOfWork.Complete();
            iContext.User = user;
        }
    }
}
