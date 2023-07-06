using System;
using TallerProgramacion2020.MediaManager.DAL.EntityFramework;

namespace TallerProgramacion2020.MediaManager.DAL
{
    /// <summary>
    /// Interfaz para la unidad de trabajo.
    /// Hereda de IDisposable para permitir la liberación de recursos.
    /// Proporciona propiedades para acceder a los repositorios relacionados.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IMediaRepository MediaRepository { get; }
        IReviewRepository ReviewRepository { get; }
        IWatchListRepository WatchListRepository { get; }

        /// <summary>
        /// Completa los cambios realizados en la unidad de trabajo.
        /// </summary>
        void Complete();

        /// <summary>
        /// Elimina todos los datos de la unidad de trabajo.
        /// </summary>
        void DeleteAll();
    }
}
