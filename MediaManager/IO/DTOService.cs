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
    /// <summary>
    /// Clase interna que proporciona métodos para la conversión entre objetos de dominio y objetos DTO.
    /// </summary>
    internal class DTOService
    {
        /// <summary>
        /// Convierte un objeto UserDTO en un objeto User y asigna los valores correspondientes de las propiedades del DTO al objeto de dominio User.
        /// </summary>
        /// <param name="pUserDTO">El objeto UserDTO a convertir.</param>
        /// <returns>El objeto User resultante.</returns>
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

        /// <summary>
        /// Actualiza un objeto User existente con los valores de un UserDTO.
        /// </summary>
        /// <param name="pUserDTO">El objeto UserDTO con los valores a actualizar.</param>
        /// <param name="pUser">El objeto User existente que se actualizará.</param>
        /// <returns>El objeto User actualizado.</returns>
        public static User FromDTOToUser(UserDTO pUserDTO, User pUser)
        {
            if (!string.IsNullOrEmpty(pUserDTO.UserName)) pUser.UserName = pUserDTO.UserName;
            if (!string.IsNullOrEmpty(pUserDTO.FullName)) pUser.FullName = pUserDTO.FullName;
            if (!string.IsNullOrEmpty(pUserDTO.Password)) pUser.PasswordHash = pUserDTO.Password.GetHashCode();
            if (pUserDTO.ProfilePhoto.Length > 0) pUser.ProfilePhoto = pUserDTO.ProfilePhoto;
            return pUser;
        }

        /// <summary>
        /// Convierte un objeto User en un objeto UserDTO y asigna los valores correspondientes de las propiedades del objeto de dominio User al DTO.
        /// </summary>
        /// <param name="pUser">El objeto User a convertir.</param>
        /// <returns>El objeto UserDTO resultante.</returns>
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

        /// <summary>
        /// Convierte un objeto Media en un objeto MediaDTO y asigna los valores correspondientes de las propiedades del objeto de dominio Media al DTO.
        /// </summary>
        /// <param name="pMedia">El objeto Media a convertir.</param>
        /// <param name="pDeep">Indica si se deben incluir conversiones profundas para propiedades relacionadas.</param>
        /// <returns>El objeto MediaDTO resultante.</returns>
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

        /// <summary>
        /// Convierte un objeto Actor en un objeto ActorDTO y asigna los valores correspondientes de las propiedades del objeto de dominio Actor al DTO.
        /// </summary>
        /// <param name="pActor">El objeto Actor a convertir.</param>
        /// <returns>El objeto ActorDTO resultante.</returns>
        public static ActorDTO AsDTO(Actor pActor)
        {
            ActorDTO dto = new ActorDTO();
            dto.ID = pActor.ID;
            dto.ITS = pActor.ITS;
            dto.UTS = pActor.UTS;
            dto.FullName = pActor.FullName;
            return dto;
        }

        /// <summary>
        /// Convierte un objeto Director en un objeto DirectorDTO y asigna los valores correspondientes de las propiedades del objeto de dominio Director al DTO.
        /// </summary>
        /// <param name="pDirector">El objeto Director a convertir.</param>
        /// <returns>El objeto DirectorDTO resultante.</returns>
        public static DirectorDTO AsDTO(Director pDirector)
        {
            DirectorDTO dto = new DirectorDTO();
            dto.ID = pDirector.ID;
            dto.ITS = pDirector.ITS;
            dto.UTS = pDirector.UTS;
            dto.FullName = pDirector.FullName;
            return dto;
        }

        /// <summary>
        /// Convierte un objeto Writer en un objeto WriterDTO y asigna los valores correspondientes de las propiedades del objeto de dominio Writer al DTO.
        /// </summary>
        /// <param name="pWriter">El objeto Writer a convertir.</param>
        /// <returns>El objeto WriterDTO resultante.</returns>
        public static WriterDTO AsDTO(Writer pWriter)
        {
            WriterDTO dto = new WriterDTO();
            dto.ID = pWriter.ID;
            dto.ITS = pWriter.ITS;
            dto.UTS = pWriter.UTS;
            dto.FullName = pWriter.FullName;
            return dto;
        }

        /// <summary>
        /// Convierte un objeto Genre en un objeto GenreDTO y asigna los valores correspondientes de las propiedades del objeto de dominio Genre al DTO.
        /// </summary>
        /// <param name="pGenre">El objeto Genre a convertir.</param>
        /// <returns>El objeto GenreDTO resultante.</returns>
        public static GenreDTO AsDTO(Genre pGenre)
        {
            GenreDTO dto = new GenreDTO();
            dto.ID = pGenre.ID;
            dto.ITS = pGenre.ITS;
            dto.UTS = pGenre.UTS;
            dto.Name = pGenre.Name;
            return dto;
        }

        /// <summary>
        /// Convierte un objeto Country en un objeto CountryDTO y asigna los valores correspondientes de las propiedades del objeto de dominio Country al DTO.
        /// </summary>
        /// <param name="pCountry">El objeto Country a convertir.</param>
        /// <returns>El objeto CountryDTO resultante.</returns>
        public static CountryDTO AsDTO(Country pCountry)
        {
            CountryDTO dto = new CountryDTO();
            dto.ID = pCountry.ID;
            dto.ITS = pCountry.ITS;
            dto.UTS = pCountry.UTS;
            dto.Name = pCountry.Name;
            return dto;
        }

        /// <summary>
        /// Convierte un objeto Review en un objeto ReviewDTO y asigna los valores correspondientes de las propiedades del objeto de dominio Review al DTO.
        /// </summary>
        /// <param name="pReview">El objeto Review a convertir.</param>
        /// <returns>El objeto ReviewDTO resultante.</returns>
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

        /// <summary>
        /// Convierte un objeto WatchListItem en un objeto WatchListItemDTO y asigna los valores correspondientes de las propiedades del objeto de dominio WatchListItem al DTO.
        /// </summary>
        /// <param name="pWatchListItem">El objeto WatchListItem a convertir.</param>
        /// <returns>El objeto WatchListItemDTO resultante.</returns>
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
