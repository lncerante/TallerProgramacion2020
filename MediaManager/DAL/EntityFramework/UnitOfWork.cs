namespace TallerProgramacion2020.MediaManager.DAL.EntityFramework
{
    /// <summary>
    /// Clase interna que implementa la interfaz IUnitOfWork.
    /// Proporciona métodos para administrar transacciones y acceder a los repositorios.
    /// </summary>
    internal class UnitOfWork : IUnitOfWork
    {
        protected readonly MediaManagerDbContext iDbContext;
        protected IUserRepository iUserRepository;
        protected IMediaRepository iMediaRepository;
        protected IReviewRepository iReviewRepository;
        protected IWatchListRepository iWatchListRepository;

        /// <summary>
        /// Propiedad de solo lectura para acceder al repositorio de usuarios.
        /// </summary>
        public IUserRepository UserRepository => iUserRepository;
        /// <summary>
        /// Propiedad de solo lectura para acceder al repositorio de medias.
        /// </summary>
        public IMediaRepository MediaRepository => iMediaRepository;
        /// <summary>
        /// Propiedad de solo lectura para acceder al repositorio de reseñas.
        /// </summary>
        public IReviewRepository ReviewRepository => iReviewRepository;
        /// <summary>
        /// Propiedad de solo lectura para acceder al repositorio de elementos de lista de seguimiento.
        /// </summary>
        public IWatchListRepository WatchListRepository => iWatchListRepository;

        /// <summary>
        /// Constructor de la clase UnitOfWork.
        /// </summary>
        /// <param name="pContext">Contexto de base de datos para el Unit of Work.</param>
        public UnitOfWork(MediaManagerDbContext pContext)
        {
            iDbContext = pContext;
            iUserRepository = new UserRepository(pContext);
            iMediaRepository = new MediaRepository(pContext);
            iReviewRepository = new ReviewRepository(pContext);
            iWatchListRepository = new WatchListRepository(pContext);
        }

        /// <summary>
        /// Completa la transacción guardando los cambios en el contexto de base de datos.
        /// </summary>
        public void Complete()
        {
            iDbContext.SaveChanges();
        }

        /// <summary>
        /// Libera los recursos utilizados por el Unit of Work y el contexto de base de datos.
        /// </summary>
        public void Dispose()
        {
            iDbContext.Dispose();
        }

        /// <summary>
        /// Elimina todos los datos de las tablas del contexto de base de datos.
        /// </summary>
        public void DeleteAll()
        {
            iDbContext.Users.RemoveRange(iDbContext.Users);
            iDbContext.Media.RemoveRange(iDbContext.Media);
            iDbContext.Reviews.RemoveRange(iDbContext.Reviews);
            iDbContext.WatchListItems.RemoveRange(iDbContext.WatchListItems);
            Complete();
        }
    }
}
