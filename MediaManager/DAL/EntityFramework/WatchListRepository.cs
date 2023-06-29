using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Security.Cryptography;
using TallerProgramacion2020.MediaManager.Domain;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TallerProgramacion2020.MediaManager.DAL.EntityFramework
{
    internal class WatchListRepository : Repository<WatchListItem, MediaManagerDbContext>, IWatchListRepository
    {

        public WatchListRepository(MediaManagerDbContext pContext) : base(pContext) { }

        public override void Create(WatchListItem pWatchListItem)
        {
            Media media = iDbContext.Media.Find(pWatchListItem.Media.ID) ?? throw new Exception("Media could not be found.");
            User user = iDbContext.Users.Find(pWatchListItem.User.ID) ?? throw new Exception("User could not be found.");
            pWatchListItem.ITS = DateTime.Now;
            iDbContext.WatchListItems.Add(pWatchListItem);
        }

        public override void Update(WatchListItem pWatchListItem)
        {
            var review = iDbContext.WatchListItems.Find(pWatchListItem.ID) ?? throw new Exception("WatchList item could not be found.");
            review.UTS = DateTime.Now;
            review.Priority = pWatchListItem.Priority;
        }

        public override void Delete(WatchListItem pWatchListItem)
        {
            iDbContext.WatchListItems.Remove(pWatchListItem);
        }

        public override WatchListItem Get(int pId)
        {
            return iDbContext.WatchListItems.Find(pId);
        }

        public override IEnumerable<WatchListItem> GetAll()
        {
            return iDbContext.WatchListItems
                .Include("User")
                .Include("Media")
                .Include("Media.Genres")
                .Include("Media.Origin")
                .Include("Media.Cast")
                .Include("Media.Director")
                .Include("Media.Writer");
        }
    }
}
