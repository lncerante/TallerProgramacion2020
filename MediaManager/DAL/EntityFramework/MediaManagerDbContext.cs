using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerProgramacion2020.MediaManager.Domain;
using TallerProgramacion2020;
using System.Data.Entity;

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
