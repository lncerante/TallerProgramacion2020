using System;

namespace TallerProgramacion2020.MediaManager.DAL
{
    internal interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }

        void Complete();

        void DeleteAll();
    }
}
