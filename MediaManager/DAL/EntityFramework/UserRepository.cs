using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.MediaManager.DAL.EntityFramework
{
    /// <summary>
    /// Clase interna que implementa la interfaz IUserRepository y hereda de Repository para la entidad User en el contexto de MediaManager.
    /// Proporciona métodos para crear, actualizar, eliminar y obtener usuarios del repositorio de usuarios.
    /// </summary>
    internal class UserRepository : Repository<User, MediaManagerDbContext>, IUserRepository
    {
        /// <summary>
        /// Constructor de la clase UserRepository.
        /// </summary>
        /// <param name="pContext">Instancia del contexto de base de datos.</param>
        public UserRepository(MediaManagerDbContext pContext) : base(pContext) { }

        /// <summary>
        /// Crea un nuevo usuario en la base de datos.
        /// </summary>
        /// <param name="pUser">Usuario a crear.</param>
        public override void Create(User pUser)
        {
            pUser.ITS = DateTime.Now;
            iDbContext.Users.Add(pUser);
        }

        /// <summary>
        /// Actualiza un usuario existente en la base de datos.
        /// </summary>
        /// <param name="pUser">Usuario a actualizar.</param>
        public override void Update(User pUser)
        {
            var user = iDbContext.Users.Find(pUser.ID);
            if (user != null)
            {
                user.UTS = DateTime.Now;
                user.UserName = pUser.UserName != null ? pUser.UserName : user.UserName;
                user.FullName = pUser.FullName != null ? pUser.FullName : user.FullName;
                //user.UserRole = pUser.UserRole; /* UserRole cannot be edited in this version */
                user.PasswordHash = pUser.PasswordHash != null ? pUser.PasswordHash : user.PasswordHash;
                user.ProfilePhoto = pUser.ProfilePhoto != null ? pUser.ProfilePhoto : user.ProfilePhoto;
            }
        }

        /// <summary>
        /// Elimina un usuario existente de la base de datos.
        /// </summary>
        /// <param name="pUser">Usuario a eliminar.</param>
        public override void Delete(User pUser)
        {
            var reviews = iDbContext.Reviews.Where(r => r.User.ID == pUser.ID);
            foreach (var item in reviews)
            {
                iDbContext.Reviews.Remove(item);
            }

            var watchList = iDbContext.WatchListItems.Where(r => r.User.ID == pUser.ID);
            foreach (var item in watchList)
            {
                iDbContext.WatchListItems.Remove(item);
            }

            iDbContext.Users.Remove(pUser);
        }

        /// <summary>
        /// Obtiene un usuario de la base de datos según su identificador.
        /// </summary>
        /// <param name="pId">Identificador del usuario.</param>
        /// <returns>Usuario encontrado o null si no se encuentra.</returns>
        public override User Get(int pId)
        {
            return iDbContext.Users.Find(pId);
        }

        /// <summary>
        /// Obtiene todos los usuarios de la base de datos.
        /// </summary>
        /// <returns>Enumeración de usuarios.</returns>
        public override IEnumerable<User> GetAll()
        {
            return iDbContext.Users;
        }

        /// <summary>
        /// Obtiene todas las Medias de la base de datos que cumplen con un listado de condiciones.
        /// </summary>
        /// <param name="pConditions">Listado de condiciones.</param>
        /// <returns>Enumeración de medias que cumplen con un listado de condiciones.</returns>
        public override IEnumerable<User> GetWhere(IEnumerable<Func<User, bool>> pConditions)
        {
            return iDbContext.Users.AsEnumerable().Where(user => pConditions.All(condition => condition(user)));
        }
    }
}
