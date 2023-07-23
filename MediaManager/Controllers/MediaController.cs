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

            if (useApi)
            {
                IEnumerable<Media> apiResult = iMediaFinder.FindMedia
                (
                    pTitle,
                    !string.IsNullOrEmpty(pGenreName) ? new Genre(pGenreName) : null,
                    pMediaType
                );

                foreach (var item in apiResult)
                {
                    Func<Media, bool>[] mediaExists =
                    {
                        m => m.ImdbID == item.ImdbID
                    };
                    
                    if (!iContext.UnitOfWork.MediaRepository.GetWhere(mediaExists).Any())
                    {
                        iContext.UnitOfWork.MediaRepository.Create(item);
                    }
                }
                iContext.UnitOfWork.Complete();
            }

            List<Func<Media, bool>> conditions = new List<Func<Media, bool>>();

            if (pMediaType != null)
            {
                conditions.Add(m => m.MediaType == pMediaType);
            }

            if (!string.IsNullOrEmpty(pGenreName))
            {
                conditions.Add(m => m.Genres.Any(g => g.Equals(new Genre(pGenreName))));
            }

            conditions.Add(m => m.Title.ToLower().Trim().Contains(pTitle.ToLower().Trim()));

            IEnumerable<Media> media = iContext.UnitOfWork.MediaRepository.GetWhere(conditions);

            if (media.Any())
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
