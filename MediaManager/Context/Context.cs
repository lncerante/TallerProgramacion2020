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
    /// <summary>
    /// Clase que representa el contexto de la aplicación.
    /// </summary>
    public class Context
    {
        protected static Context _instance;

        protected IUnitOfWork iUnitOfWork;

        protected User iUser;

        /// <summary>
        /// Constructor protegido de la clase Context.
        /// </summary>
        protected Context()
        {
            iUnitOfWork = new UnitOfWork(new MediaManagerDbContext());
            iUser = null;
        }

        /// <summary>
        /// Método estático para obtener una instancia del contexto.
        /// </summary>
        /// <returns>Instancia del contexto.</returns>
        public static Context GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Context();
            }
            return _instance;
        }

        /// <summary>
        /// Unidad de trabajo asociada al contexto.
        /// </summary>
        public IUnitOfWork UnitOfWork
        {
            get { return iUnitOfWork; }
        }

        /// <summary>
        /// Usuario asociado al contexto.
        /// </summary>
        public User User
        {
            get { return iUser; }
            set { iUser = value; }
        }
    }
}
