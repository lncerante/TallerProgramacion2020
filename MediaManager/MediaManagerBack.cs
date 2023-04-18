using TallerProgramacion2020.MediaManager.DAL;
using TallerProgramacion2020.MediaManager.DAL.EntityFramework;
using TallerProgramacion2020.MediaManager.Domain;
using TallerProgramacion2020.MediaManager.IO;

namespace TallerProgramacion2020.MediaManager
{
    public class MediaManagerBack
    {
        private IUnitOfWork iUnitOfWork;

        public MediaManagerBack()
        {
            iUnitOfWork = new UnitOfWork(new MediaManagerDbContext());
        }

        private UserDTO AsDTO(User pUser)
        {
            UserDTO dto = new UserDTO();
            dto.ID = pUser.ID;
            dto.ITS = pUser.ITS;
            dto.UTS = pUser.UTS;
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
