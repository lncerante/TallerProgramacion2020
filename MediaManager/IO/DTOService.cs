using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
using System.Text;
using System.Threading.Tasks;
using TallerProgramacion2020.MediaManager.DAL;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.MediaManager.IO
{
    internal class DTOService
    {
        public static User FromDTO(UserDTO pUserDTO)
        {
            User user = new User();
            user.ID = pUserDTO.ID;
            user.ITS = pUserDTO.ITS;
            user.UTS = pUserDTO.UTS;
            user.UserName = pUserDTO.UserName;
            user.FullName = pUserDTO.FullName;
            if (!string.IsNullOrEmpty(pUserDTO.Password)) user.PasswordHash = pUserDTO.Password.GetHashCode();
            user.UserRole = pUserDTO.UserRole;
            user.ProfilePhoto = pUserDTO.ProfilePhoto;
            return user;
        }

        public static User FromDTOToUser(UserDTO pUserDTO, User pUser)
        {
            if (!string.IsNullOrEmpty(pUserDTO.UserName)) pUser.UserName = pUserDTO.UserName;
            if (!string.IsNullOrEmpty(pUserDTO.FullName)) pUser.FullName = pUserDTO.FullName;
            if (!string.IsNullOrEmpty(pUserDTO.Password)) pUser.PasswordHash = pUserDTO.Password.GetHashCode();
            if (pUserDTO.ProfilePhoto.Length > 0) pUser.ProfilePhoto = pUserDTO.ProfilePhoto;
            return pUser;
        }

        public static UserDTO AsDTO(User pUser)
        {
            UserDTO dto = new UserDTO();
            dto.ID = pUser.ID;
            dto.ITS = pUser.ITS;
            dto.UTS = pUser.UTS;
            dto.UserName = pUser.UserName;
            dto.FullName = pUser.FullName;
            dto.UserRole = pUser.UserRole;
            dto.ProfilePhoto = pUser.ProfilePhoto;
            return dto;
        }

        public static MediaDTO AsDTO(Media pMedia, bool pDeep = true)
        {
            MediaDTO dto = new MediaDTO();
            dto.ID = pMedia.ID;
            dto.ITS = pMedia.ITS;
            dto.UTS = pMedia.UTS;
            dto.ImdbID = pMedia.ImdbID;
            dto.ImdbRating = pMedia.ImdbRating;
            dto.Year = pMedia.Year;
            dto.Title = pMedia.Title;
            dto.Poster = pMedia.Poster;
            dto.MediaType = pMedia.MediaType;
            dto.ReleaseDate = pMedia.ReleaseDate;
            dto.RuntimeInMin = pMedia.RuntimeInMin;
            if (pDeep)
            {
                dto.Cast = pMedia.Cast.Select(actor => AsDTO(actor));
                dto.Writer = pMedia.Writer.Select(writer => AsDTO(writer));
                dto.Director = pMedia.Director.Select(director => AsDTO(director));
                dto.Genres = pMedia.Genres.Select(genre => AsDTO(genre));
                dto.Origin = pMedia.Origin.Select(country => AsDTO(country));
            }
            return dto;
        }

        public static ActorDTO AsDTO(Actor pActor)
        {
            ActorDTO dto = new ActorDTO();
            dto.ID = pActor.ID;
            dto.ITS = pActor.ITS;
            dto.UTS = pActor.UTS;
            dto.FullName = pActor.FullName;
            return dto;
        }

        public static DirectorDTO AsDTO(Director pDirector)
        {
            DirectorDTO dto = new DirectorDTO();
            dto.ID = pDirector.ID;
            dto.ITS = pDirector.ITS;
            dto.UTS = pDirector.UTS;
            dto.FullName = pDirector.FullName;
            return dto;
        }

        public static WriterDTO AsDTO(Writer pWriter)
        {
            WriterDTO dto = new WriterDTO();
            dto.ID = pWriter.ID;
            dto.ITS = pWriter.ITS;
            dto.UTS = pWriter.UTS;
            dto.FullName = pWriter.FullName;
            return dto;
        }

        public static GenreDTO AsDTO(Genre pGenre)
        {
            GenreDTO dto = new GenreDTO();
            dto.ID = pGenre.ID;
            dto.ITS = pGenre.ITS;
            dto.UTS = pGenre.UTS;
            dto.Name = pGenre.Name;
            return dto;
        }

        public static CountryDTO AsDTO(Country pCountry)
        {
            CountryDTO dto = new CountryDTO();
            dto.ID = pCountry.ID;
            dto.ITS = pCountry.ITS;
            dto.UTS = pCountry.UTS;
            dto.Name = pCountry.Name;
            return dto;
        }

        public static ReviewDTO AsDTO(Review pReview)
        {
            ReviewDTO dto = new ReviewDTO();
            dto.ID = pReview.ID;
            dto.ITS = pReview.ITS;
            dto.UTS = pReview.UTS;
            dto.Rating = pReview.Rating;
            dto.Comment = pReview.Comment;
            dto.User = AsDTO(pReview.User);
            dto.Media = AsDTO(pReview.Media);
            return dto;
        }

        public static WatchListItemDTO AsDTO(WatchListItem pWatchListItem)
        {
            WatchListItemDTO dto = new WatchListItemDTO();
            dto.ID = pWatchListItem.ID;
            dto.ITS = pWatchListItem.ITS;
            dto.UTS = pWatchListItem.UTS;
            dto.Priority = pWatchListItem.Priority;
            dto.User = AsDTO(pWatchListItem.User);
            dto.Media = AsDTO(pWatchListItem.Media);
            return dto;
        }
    }
}
