using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.MediaManager.DAL.EntityFramework
{
    internal class UserRepository : Repository<User, MediaManagerDbContext>, IUserRepository
    {

        public UserRepository(MediaManagerDbContext pContext) : base(pContext) { }

        public override void Create(User pUser)
        {
            pUser.ITS = DateTime.Now;
            iDbContext.Users.Add(pUser);
        }

        public override void Update(User pUser)
        {
            var user = iDbContext.Users.Find(pUser.ID);
            if (user != null)
            {
                user.UTS = DateTime.Now;
                user.UserName = pUser.UserName != null ? pUser.UserName : user.UserName;
                user.FullName = pUser.FullName != null ? pUser.FullName : user.FullName;
                //user.UserRole = pUser.UserRole; /* UserRole cannot be edited in this version */
                user.PasswordHash = pUser.PasswordHash != null ? pUser.PasswordHash : user.PasswordHash;
                user.ProfilePhoto = pUser.ProfilePhoto != null ? pUser.ProfilePhoto : user.ProfilePhoto;
            }
        }

        public override void Delete(User pUser)
        {
            var reviews = iDbContext.Reviews.Where(r => r.User.ID == pUser.ID);
            foreach (var item in reviews)
            {
                iDbContext.Reviews.Remove(item);
            }

            var watchList = iDbContext.WatchListItems.Where(r => r.User.ID == pUser.ID);
            foreach (var item in watchList)
            {
                iDbContext.WatchListItems.Remove(item);
            }

            iDbContext.Users.Remove(pUser);
        }

        public override User Get(int pId)
        {
            return iDbContext.Users.Find(pId);
        }

        public override IEnumerable<User> GetAll()
        {
            return iDbContext.Users;
        }
    }
}
