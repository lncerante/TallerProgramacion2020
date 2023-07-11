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
    /// <summary>
    /// Controlador para la gestión de películas y series.
    /// </summary>
    public class MediaController
    {
        protected Context iContext;
        protected IMediaFinder iMediaFinder;

        /// <summary>
        /// Constructor de la clase MediaController.
        /// </summary>
        public MediaController()
        {
            iContext = Context.GetInstance();
            iMediaFinder = new OmdbApiMediaFinder();
        }

        /// <summary>
        /// Obtiene todas las películas y series disponibles.
        /// </summary>
        /// <returns>Una colección de objetos MediaDTO.</returns>
        public IEnumerable<MediaDTO> GetMedia()
        {
            var media = iContext.UnitOfWork.MediaRepository.GetAll();

            return media.Select(m => DTOService.AsDTO(m));
        }

        /// <summary>
        /// Busca películas y series basadas en el título, el nombre del género y el tipo.
        /// </summary>
        /// <param name="pTitle">El título a buscar.</param>
        /// <param name="pGenreName">El nombre del género a buscar.</param>
        /// <param name="pMediaType">El tipo de media a buscar.</param>
        /// <param name="useApi">Indica si se debe utilizar una API para buscar los medios.</param>
        /// <returns>Una colección de objetos MediaDTO que coinciden con los criterios de búsqueda.</returns>
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

            media = iContext.UnitOfWork.MediaRepository.GetAll().AsEnumerable();

            media = media.Where(m => m.Title.ToLower().Trim().Contains(pTitle.ToLower().Trim()));

            if (pMediaType != null)
            {
                media = media.Where(m => m.MediaType == pMediaType);
            }

            if (!string.IsNullOrEmpty(pGenreName))
            {
                media = media.Where(m => m.Genres.Any(g => g.Equals(new Genre(pGenreName))));
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
