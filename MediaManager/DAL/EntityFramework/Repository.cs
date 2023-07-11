using System.Collections.Generic;

namespace TallerProgramacion2020.MediaManager.DAL.EntityFramework
{
    /// <summary>
    /// Clase abstracta que sirve como base para los repositorios.
    /// Implementa la interfaz IRepository y define métodos abstractos para crear, actualizar, eliminar, obtener y obtener todos los elementos.
    /// </summary>
    /// <typeparam name="TEntity">El tipo de entidad que maneja el repositorio.</typeparam>
    /// <typeparam name="TDbContext">El tipo de contexto de base de datos utilizado por el repositorio.</typeparam>
    internal abstract class Repository<TEntity, TDbContext> : IRepository<TEntity>
    {
        protected readonly TDbContext iDbContext;

        /// <summary>
        /// Constructor de la clase Repository.
        /// </summary>
        /// <param name="pContext">El contexto de base de datos utilizado por el repositorio.</param>
        public Repository(TDbContext pContext)
        {
            iDbContext = pContext;
        }
        /// <summary>
        /// Crea una nueva entidad en el repositorio.
        /// </summary>
        /// <param name="pEntity">La entidad a crear.</param>
        public abstract void Create(TEntity pEntity);

        /// <summary>
        /// Actualiza una entidad existente en el repositorio.
        /// </summary>
        /// <param name="pEntity">La entidad a actualizar.</param>
        public abstract void Update(TEntity pEntity);

        /// <summary>
        /// Elimina una entidad del repositorio.
        /// </summary>
        /// <param name="pEntity">La entidad a eliminar.</param>
        public abstract void Delete(TEntity pEntity);

        /// <summary>
        /// Obtiene una entidad del repositorio por su ID.
        /// </summary>
        /// <param name="pId">El ID de la entidad a obtener.</param>
        /// <returns>La entidad encontrada, o null si no se encontró.</returns>
        public abstract TEntity Get(int pId);

        /// <summary>
        /// Obtiene todas las entidades del repositorio.
        /// </summary>
        /// <returns>Una colección de todas las entidades.</returns>
        public abstract IEnumerable<TEntity> GetAll();
    }
}
