using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Security.Cryptography;
using TallerProgramacion2020.MediaManager.Domain;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TallerProgramacion2020.MediaManager.DAL.EntityFramework
{
    /// <summary>
    /// Clase interna que hereda de Repository y representa el repositorio para la entidad WatchListItem.
    /// Proporciona métodos para realizar operaciones de creación, actualización, eliminación y consulta en la base de datos.
    /// </summary>
    internal class WatchListRepository : Repository<WatchListItem, MediaManagerDbContext>, IWatchListRepository
    {
        /// <summary>
        /// Constructor de la clase WatchListRepository.
        /// </summary>
        /// <param name="pContext">Instancia del contexto de base de datos.</param>
        public WatchListRepository(MediaManagerDbContext pContext) : base(pContext) { }

        /// <summary>
        /// Crea un nuevo elemento de lista de seguimiento en la base de datos.
        /// </summary>
        /// <param name="pWatchListItem">Elemento de lista de seguimiento a crear.</param>
        public override void Create(WatchListItem pWatchListItem)
        {
            Media media = iDbContext.Media.Find(pWatchListItem.Media.ID) ?? throw new Exception("Media could not be found.");
            User user = iDbContext.Users.Find(pWatchListItem.User.ID) ?? throw new Exception("User could not be found.");
            pWatchListItem.ITS = DateTime.Now;
            iDbContext.WatchListItems.Add(pWatchListItem);
        }

        /// <summary>
        /// Actualiza un elemento de lista de seguimiento existente en la base de datos.
        /// </summary>
        /// <param name="pWatchListItem">Elemento de lista de seguimiento a actualizar.</param>
        public override void Update(WatchListItem pWatchListItem)
        {
            var review = iDbContext.WatchListItems.Find(pWatchListItem.ID) ?? throw new Exception("WatchList item could not be found.");
            review.UTS = DateTime.Now;
            review.Priority = pWatchListItem.Priority;
        }

        /// <summary>
        /// Elimina un elemento de lista de seguimiento existente de la base de datos.
        /// </summary>
        /// <param name="pWatchListItem">Elemento de lista de seguimiento a eliminar.</param>
        public override void Delete(WatchListItem pWatchListItem)
        {
            iDbContext.WatchListItems.Remove(pWatchListItem);
        }

        /// <summary>
        /// Obtiene un elemento de lista de seguimiento (WatchListItem) de la base de datos según su identificador.
        /// </summary>
        /// <param name="pId">Identificador del elemento de lista de seguimiento.</param>
        /// <returns>Elemento de lista de seguimiento encontrado o null si no se encuentra.</returns>
        public override WatchListItem Get(int pId)
        {
            return iDbContext.WatchListItems.Find(pId);
        }

        /// <summary>
        /// Obtiene todos los elementos de la lista de seguimiento (WatchListItem) de la base de datos.
        /// </summary>
        /// <returns>Enumeración de elementos de lista de seguimiento.</returns>
        public override IEnumerable<WatchListItem> GetAll()
        {
            return iDbContext.WatchListItems
                .Include("User")
                .Include("Media")
                .Include("Media.Genres")
                .Include("Media.Origin")
                .Include("Media.Cast")
                .Include("Media.Director")
                .Include("Media.Writer");
        }
    }
}
