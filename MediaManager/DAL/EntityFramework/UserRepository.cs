using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerProgramacion2020.MediaManager.Domain;
using TallerProgramacion2020.MediaManager.DAL;

namespace TallerProgramacion2020.MediaManager.DAL.EntityFramework
{
    internal class UserRepository : Repository<User, MediaManagerDbContext>, IUserRepository
    {

        public UserRepository(MediaManagerDbContext pContext) : base(pContext) { }

        public override void Create(User pUser)
        {
            iDbContext.Users.Add(pUser);
        }

        public override void Update(User pUser)
        {
            iDbContext.Users.Find(pUser);
        }

        public override void Delete(User pUser)
        {
            iDbContext.Users.Remove(pUser);
        }

        public override User Get(int pId)
        {
            foreach (User User in iDbContext.Users)
            {
                if (User.ID == pId)
                    return User;
            }
            return null;
        }

        public override IEnumerable<User> GetAll()
        {
            return iDbContext.Users;
        }
    }
}
