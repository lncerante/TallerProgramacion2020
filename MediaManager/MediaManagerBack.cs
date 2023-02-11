using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerProgramacion2020.MediaManager.Domain;
using TallerProgramacion2020.MediaManager.DAL;
using TallerProgramacion2020.MediaManager.IO;
using TallerProgramacion2020.MediaManager.DAL.EntityFramework;

namespace TallerProgramacion2020.MediaManager
{
    public class MediaManagerBack
    {
        private IUnitOfWork iUnitOfWork;

        public MediaManagerBack()
        {
            iUnitOfWork = new UnitOfWork(new MediaManagerDbContext());
        }

        private void SetBaseDTO(BaseObjectDTO pBaseObjectDTO, BaseObject pBaseObject) 
        {
            pBaseObjectDTO.ID = pBaseObject.ID;
            pBaseObjectDTO.ITS = pBaseObject.ITS;
            pBaseObjectDTO.UTS = pBaseObject.UTS;
        }

        private UserDTO AsDTO(User pUser)
        {
            UserDTO dto = new UserDTO();
            SetBaseDTO(dto, pUser);
            dto.UserName = pUser.UserName;
            dto.FullName = pUser.FullName;
            dto.ProfilePhoto = pUser.ProfilePhoto;
            return dto;
        }

        private User FromDTO(UserDTO pUserDTO)
        {
            User user = new User();
            user.UserName = pUserDTO.UserName;
            user.FullName = pUserDTO.FullName;
            user.ProfilePhoto = pUserDTO.ProfilePhoto;
            return user;
        }

        public void CreateUser(UserDTO pUserDTO)
        {
            User user = FromDTO(pUserDTO);
            iUnitOfWork.UserRepository.Create(user);
            iUnitOfWork.Complete();
        }
    }
}
