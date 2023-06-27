namespace TallerProgramacion2020.MediaManager.DAL.EntityFramework
{
    internal class UnitOfWork : IUnitOfWork
    {
        protected readonly MediaManagerDbContext iDbContext;
        protected IUserRepository iUserRepository;
        protected IMediaRepository iMediaRepository;

        public IUserRepository UserRepository => iUserRepository;
        public IMediaRepository MediaRepository => iMediaRepository;

        public UnitOfWork(MediaManagerDbContext pContext)
        {
            iDbContext = pContext;
            iUserRepository = new UserRepository(pContext);
            iMediaRepository = new MediaRepository(pContext);
        }

        public void Complete()
        {
            iDbContext.SaveChanges();
        }

        public void Dispose()
        {
            iDbContext.Dispose();
        }

        public void DeleteAll()
        {
            iDbContext.Users.RemoveRange(iDbContext.Users);
            Complete();
        }
    }
}
