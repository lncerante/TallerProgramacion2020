using TallerProgramacion2020.MediaManager.Domain;


namespace TallerProgramacion2020.MediaManager.DAL
{
    /// <summary>
    /// Interfaz específica de repositorio para entidades de tipo WatchListItem.
    /// Hereda de la interfaz genérica IRepository<WatchListItem>.
    /// </summary>
    public interface IWatchListRepository : IRepository<WatchListItem>
    {
    }
}
