namespace TallerProgramacion2020.MediaManager.DAL.EntityFramework
{
    internal class UnitOfWork : IUnitOfWork
    {
        protected readonly MediaManagerDbContext iDbContext;
        protected IUserRepository iUserRepository;
        protected IMediaRepository iMediaRepository;
        protected IReviewRepository iReviewRepository;
        protected IWatchListRepository iWatchListRepository;

        public IUserRepository UserRepository => iUserRepository;
        public IMediaRepository MediaRepository => iMediaRepository;
        public IReviewRepository ReviewRepository => iReviewRepository;
        public IWatchListRepository WatchListRepository => iWatchListRepository;

        public UnitOfWork(MediaManagerDbContext pContext)
        {
            iDbContext = pContext;
            iUserRepository = new UserRepository(pContext);
            iMediaRepository = new MediaRepository(pContext);
            iReviewRepository = new ReviewRepository(pContext);
            iWatchListRepository = new WatchListRepository(pContext);
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
            iDbContext.Media.RemoveRange(iDbContext.Media);
            iDbContext.Reviews.RemoveRange(iDbContext.Reviews);
            iDbContext.WatchListItems.RemoveRange(iDbContext.WatchListItems);
            Complete();
        }
    }
}
