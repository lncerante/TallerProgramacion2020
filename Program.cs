using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TallerProgramacion2020.MediaManager;
using TallerProgramacion2020.MediaManager.Domain;
using TallerProgramacion2020.MediaManager.IO;
using TallerProgramacion2020.MediaManager.DAL;
using TallerProgramacion2020.MediaManager.DAL.EntityFramework;


namespace TallerProgramacion2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var unit = new UnitOfWork(new MediaManagerDbContext());
        }
    }
}
