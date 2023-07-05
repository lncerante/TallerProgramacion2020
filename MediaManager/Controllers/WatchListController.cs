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
    public class WatchListController
    {
        protected Context iContext;

        public WatchListController()
        {
            iContext = Context.GetInstance();
        }

        public IEnumerable<WatchListItemDTO> GetWatchList()
        {
            var watchListItems = iContext.UnitOfWork.WatchListRepository
                .GetAll()
                .Where(i => i.User.ID == iContext.User.ID)
                .OrderByDescending(i => i.Priority);

            return watchListItems.Select(watchListItem => DTOService.AsDTO(watchListItem));
        }

        public void CreateWatchListItem(int pMediaID, Priority pPriority)
        {
            Media media = iContext.UnitOfWork.MediaRepository.Get(pMediaID) ?? throw new Exception("Media could not be found.");
            var exists = iContext.UnitOfWork.WatchListRepository.GetAll()
                .Where(i => i.User.ID == iContext.User.ID && i.Media.ID == pMediaID);
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

        public void UpdateWatchListItem(int pWatchListItemId, Priority pPriority)
        {
            WatchListItem watchListItem = iContext.UnitOfWork.WatchListRepository.Get(pWatchListItemId) ?? throw new Exception("WatchList item could not be found.");

            watchListItem.Priority = pPriority;

            iContext.UnitOfWork.WatchListRepository.Update(watchListItem);
            iContext.UnitOfWork.Complete();
        }

        public void DeleteWatchList(int pWatchListItemId)
        {
            WatchListItem watchListItem = iContext.UnitOfWork.WatchListRepository.Get(pWatchListItemId) ?? throw new Exception("WatchList item could not be found.");

            iContext.UnitOfWork.WatchListRepository.Delete(watchListItem);
            iContext.UnitOfWork.Complete();
        }
    }
}
