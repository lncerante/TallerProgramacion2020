using System;
using TallerProgramacion2020.MediaManager.DAL.EntityFramework;

namespace TallerProgramacion2020.MediaManager.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IMediaRepository MediaRepository { get; }
        IReviewRepository ReviewRepository { get; }
        IWatchListRepository WatchListRepository { get; }

        void Complete();

        void DeleteAll();
    }
}
