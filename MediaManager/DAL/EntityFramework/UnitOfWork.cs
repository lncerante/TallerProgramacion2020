namespace TallerProgramacion2020.MediaManager.DAL.EntityFramework
{
    internal class UnitOfWork : IUnitOfWork
    {
        protected readonly MediaManagerDbContext iDbContext;
        protected IUserRepository iUserRepository;

        public IUserRepository UserRepository => iUserRepository;

        public UnitOfWork(MediaManagerDbContext pContext)
        {
            iDbContext = pContext;
            iUserRepository = new UserRepository(pContext);
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
