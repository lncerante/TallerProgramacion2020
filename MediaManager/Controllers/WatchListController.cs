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
    /// <summary>
    /// Controlador para la gestión de la lista de seguimiento.
    /// </summary>
    public class WatchListController
    {
        protected Context iContext;

        /// <summary>
        /// Constructor de la clase WatchListController.
        /// </summary>
        public WatchListController()
        {
            iContext = Context.GetInstance();
        }

        /// <summary>
        /// Obtiene la lista de elementos de la lista de seguimiento del usuario actual.
        /// </summary>
        /// <returns>Una colección de WatchListItemDTO que representa los elementos de la lista de 
        /// seguimiento.</returns>
        public IEnumerable<WatchListItemDTO> GetWatchList()
        {
            Func<WatchListItem, bool>[] conditions =
            {
                i => i.User.ID == iContext.User.ID
            };
            var watchListItems = iContext.UnitOfWork.WatchListRepository
                .GetWhere(conditions)
                .OrderByDescending(i => i.Priority);

            return watchListItems.Select(watchListItem => DTOService.AsDTO(watchListItem));
        }

        /// <summary>
        /// Crea un nuevo elemento en la lista de seguimiento.
        /// </summary>
        /// <param name="pMediaID">El ID de la media a agregar a la lista de seguimiento.</param>
        /// <param name="pPriority">La prioridad del elemento en la lista de seguimiento.</param>
        /// <exception cref="Exception">Se lanzará una excepción si el medio no se encuentra o si
        /// ya está agregado a la lista de seguimiento.</exception>
        public void CreateWatchListItem(int pMediaID, Priority pPriority)
        {
            Media media = iContext.UnitOfWork.MediaRepository.Get(pMediaID) ?? throw new Exception("Media could not be found.");

            Func<WatchListItem, bool>[] conditions =
            {
                i => i.User.ID == iContext.User.ID,
                i => i.Media.ID == pMediaID
            };
            var exists = iContext.UnitOfWork.WatchListRepository.GetWhere(conditions);

            if (exists.Count() > 0)
            {
                throw new Exception("You have already added this media to your list.");
            }

            WatchListItem watchListItem = new WatchListItem
            {
                User = iContext.User,
                Media = media,
                Priority = pPriority
            };

            iContext.UnitOfWork.WatchListRepository.Create(watchListItem);
            iContext.UnitOfWork.Complete();
        }

        /// <summary>
        /// Actualiza la prioridad de un elemento en la lista de seguimiento.
        /// </summary>
        /// <param name="pWatchListItemId">El ID del elemento de la lista de seguimiento a actualizar.</param>
        /// <param name="pPriority">La nueva prioridad del elemento.</param>
        /// <exception cref="Exception">Se lanzará una excepción si el elemento de la lista de seguimiento 
        /// no se encuentra.</exception>
        public void UpdateWatchListItem(int pWatchListItemId, Priority pPriority)
        {
            WatchListItem watchListItem = iContext.UnitOfWork.WatchListRepository.Get(pWatchListItemId) ?? throw new Exception("WatchList item could not be found.");

            watchListItem.Priority = pPriority;

            iContext.UnitOfWork.WatchListRepository.Update(watchListItem);
            iContext.UnitOfWork.Complete();
        }

        /// <summary>
        /// Elimina un elemento de la lista de seguimiento.
        /// </summary>
        /// <param name="pWatchListItemId">El ID del elemento de la lista de seguimiento a eliminar.</param>
        /// <exception cref="Exception">Se lanzará una excepción si el elemento de la lista de seguimiento
        /// no se encuentra.</exception>
        public void DeleteWatchList(int pWatchListItemId)
        {
            WatchListItem watchListItem = iContext.UnitOfWork.WatchListRepository.Get(pWatchListItemId) ?? throw new Exception("WatchList item could not be found.");

            iContext.UnitOfWork.WatchListRepository.Delete(watchListItem);
            iContext.UnitOfWork.Complete();
        }
    }
}
