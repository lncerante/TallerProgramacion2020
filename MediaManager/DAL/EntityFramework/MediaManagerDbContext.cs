using System.Data.Entity;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.MediaManager.DAL.EntityFramework
{
    internal class MediaManagerDbContext : DbContext
    {
        protected DbSet<User> iUsers;

        public MediaManagerDbContext() : base("MediaManagerDb")
        { }

        public DbSet<User> Users { get => iUsers; set => iUsers = value; }
    }
}
