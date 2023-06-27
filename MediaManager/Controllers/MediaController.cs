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
using TallerProgramacion2020.MediaManager.ApiAccess;
using TallerProgramacion2020.MediaManager.ApiAccess.ImdbApi;
using System.Web.UI.WebControls;

namespace TallerProgramacion2020.MediaManager.Controllers
{
    public class MediaController
    {
        protected Context iContext;
        protected IMediaFinder iMediaFinder;

        public MediaController()
        {
            iContext = Context.GetInstance();
            iMediaFinder = new OmdbApiMediaFinder();
        }

        public IEnumerable<MediaDTO> GetMedia()
        {
            var media = iContext.UnitOfWork.MediaRepository.GetAll();

            return media.Select(m => DTOService.AsDTO(m));
        }

        public IEnumerable<MediaDTO> SearchMedia(string pTitle, string pGenreName, MediaType? pMediaType, bool useApi = false)
        {
            if (string.IsNullOrEmpty(pTitle))
            {
                throw new Exception("Title is required.");
            }

            IEnumerable<Media> media = iContext.UnitOfWork.MediaRepository.GetAll();

            if (useApi)
            {
                var imdbIds = media.Select(m => m.ImdbID);
                IEnumerable<Media> apiResult = iMediaFinder.FindMedia
                (
                    pTitle,
                    !string.IsNullOrEmpty(pGenreName) ? new Genre(pGenreName) : null,
                    pMediaType
                );

                foreach (var item in apiResult)
                {
                    if (!imdbIds.Contains(item.ImdbID))
                    {
                        iContext.UnitOfWork.MediaRepository.Create(item);
                        iContext.UnitOfWork.Complete();
                    }
                }
            }

            media = iContext.UnitOfWork.MediaRepository.GetAll();

            media = media.Where(m => m.Title.ToLower().Trim().Contains(pTitle.ToLower().Trim()));

            if (pMediaType != null)
            {
                media = media.Where(m => m.MediaType == pMediaType);
            }

            if (!string.IsNullOrEmpty(pGenreName))
            {
                media = media.Where(m => m.Genres.Any(g => g == new Genre(pGenreName)));
            }

            if (media.Count() > 0)
            {
                return media.Select(m => DTOService.AsDTO(m));
            }

            if (!useApi)
            {
                return SearchMedia(pTitle, pGenreName, pMediaType, true);
            }

            return null;
        }
    }
}
