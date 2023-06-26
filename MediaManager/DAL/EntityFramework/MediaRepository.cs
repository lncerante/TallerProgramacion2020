using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.MediaManager.DAL.EntityFramework
{
    internal class MediaRepository : Repository<Media, MediaManagerDbContext>, IMediaRepository
    {

        public MediaRepository(MediaManagerDbContext pContext) : base(pContext) { }

        public override void Create(Media pMedia)
        {
            pMedia.ITS = DateTime.Now;

            foreach (var item in pMedia.Cast)
            {
                var dbItem = iDbContext.Actors.FirstOrDefault(i => i == item);
                if (dbItem != null)
                {
                    item.ID = dbItem.ID;
                }
                else
                {
                    item.ITS = DateTime.Now;
                    iDbContext.Actors.Add(item);
                }
            }

            foreach (var item in pMedia.Director)
            {
                var dbItem = iDbContext.Directors.FirstOrDefault(i => i == item);
                if (dbItem != null)
                {
                    item.ID = dbItem.ID;
                }
                else
                {
                    item.ITS = DateTime.Now;
                    iDbContext.Directors.Add(item);
                }
            }

            foreach (var item in pMedia.Genres)
            {
                var dbItem = iDbContext.Genres.FirstOrDefault(i => i == item);
                if (dbItem != null)
                {
                    item.ID = dbItem.ID;
                }
                else
                {
                    item.ITS = DateTime.Now;
                    iDbContext.Genres.Add(item);
                }
            }

            foreach (var item in pMedia.Origin)
            {
                var dbItem = iDbContext.Countries.FirstOrDefault(i => i == item);
                if (dbItem != null)
                {
                    item.ID = dbItem.ID;
                }
                else
                {
                    item.ITS = DateTime.Now;
                    iDbContext.Countries.Add(item);
                }
            }

            foreach (var item in pMedia.Writer)
            {
                var dbItem = iDbContext.Writers.FirstOrDefault(i => i == item);
                if (dbItem != null)
                {
                    item.ID = dbItem.ID;
                }
                else
                {
                    item.ITS = DateTime.Now;
                    iDbContext.Writers.Add(item);
                }
            }

            iDbContext.Media.Add(pMedia);
        }

        public override void Update(Media pMedia)
        {
            throw new Exception("Media is readonly.");
        }

        public override void Delete(Media pMedia)
        {
            iDbContext.Media.Remove(pMedia);
        }

        public override Media Get(int pId)
        {
            return iDbContext.Media.Find(pId);
        }

        public override IEnumerable<Media> GetAll()
        {
            return iDbContext.Media;
        }
    }
}
