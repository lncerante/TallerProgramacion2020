using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerProgramacion2020.MediaManager;
using TallerProgramacion2020.MediaManager.DAL;
using TallerProgramacion2020.MediaManager.DAL.EntityFramework;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.MediaManager.ContextClass
{
    public class Context
    {
        protected static Context _instance;

        protected IUnitOfWork iUnitOfWork;

        protected User iUser;

        protected Context()
        {
            iUnitOfWork = new UnitOfWork(new MediaManagerDbContext());
            iUser = null;
        }

        public static Context GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Context();
            }
            return _instance;
        }

        public IUnitOfWork UnitOfWork
        {
            get { return iUnitOfWork; }
        }

        public User User
        {
            get { return iUser; }
            set { iUser = value; }
        }
    }
}
