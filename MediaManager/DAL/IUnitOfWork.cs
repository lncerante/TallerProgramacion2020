using System;

namespace TallerProgramacion2020.MediaManager.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IMediaRepository MediaRepository { get; }

        void Complete();

        void DeleteAll();
    }
}
