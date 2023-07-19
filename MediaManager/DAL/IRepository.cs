using System;
using System.Collections.Generic;

namespace TallerProgramacion2020.MediaManager.DAL
{
    /// <summary>
    /// Interfaz genérica para un repositorio que proporciona operaciones básicas de CRUD.
    /// </summary>
    /// <typeparam name="TEntity">El tipo de entidad con la que opera el repositorio.</typeparam>
    public interface IRepository<TEntity>
    {
        /// <summary>
        /// Crea una nueva entidad en el repositorio.
        /// </summary>
        /// <param name="pEntity">La entidad a crear.</param>
        void Create(TEntity pEntity);

        /// <summary>
        /// Actualiza una entidad existente en el repositorio.
        /// </summary>
        /// <param name="pEntity">La entidad a actualizar.</param>
        void Update(TEntity pEntity);

        /// <summary>
        /// Elimina una entidad del repositorio.
        /// </summary>
        /// <param name="pEntity">La entidad a eliminar.</param>
        void Delete(TEntity pEntity);

        /// <summary>
        /// Obtiene una entidad del repositorio según su ID.
        /// </summary>
        /// <param name="pId">El ID de la entidad a obtener.</param>
        /// <returns>La entidad correspondiente al ID especificado.</returns>
        TEntity Get(int pId);

        /// <summary>
        /// Obtiene todas las entidades almacenadas en el repositorio.
        /// </summary>
        /// <returns>Una colección de todas las entidades del repositorio.</returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Obtiene todas las entidades almacenadas en el repositorio que cumplen con un listado de condiciones.
        /// </summary>
        /// <param name="pConditions">Listado de condiciones.</param>
        /// <returns>Una colección de todas las entidades del repositorio que cumplen con un listado de condiciones.</returns>
        IEnumerable<TEntity> GetWhere(IEnumerable<Func<TEntity, bool>> pConditions);
    }
}
