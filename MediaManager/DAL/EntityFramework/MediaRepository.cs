using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using TallerProgramacion2020.MediaManager.Domain;
using TallerProgramacion2020.ToolsClass;

namespace TallerProgramacion2020.MediaManager.DAL.EntityFramework
{
    /// <summary>
    /// Clase interna que hereda de Repository y representa el repositorio para la entidad Media.
    /// Proporciona métodos para realizar operaciones de creación, actualización, eliminación y consulta en la base de datos.
    /// </summary>
    internal class MediaRepository : Repository<Media, MediaManagerDbContext>, IMediaRepository
    {
        /// <summary>
        /// Constructor de la clase MediaRepository.
        /// </summary>
        /// <param name="pContext">Instancia del contexto de base de datos.</param>
        public MediaRepository(MediaManagerDbContext pContext) : base(pContext) { }

        /// <summary>
        /// Crea una nueva Media en la base de datos.
        /// </summary>
        /// <param name="pMedia">Media a crear.</param>
        public override void Create(Media pMedia)
        {
            pMedia.ITS = DateTime.Now;

            var cast = new List<Actor>();
            foreach (Actor item in pMedia.Cast)
            {
                var dbItem = iDbContext.Actors.Where(i => Tools.Equals(i.FullName, item.FullName)).AsEnumerable();
                if (dbItem.Count() > 0)
                {
                    cast.Add(dbItem.First());
                }
                else
                {
                    item.ITS = DateTime.Now;
                    cast.Add(item);
                }
            }
            pMedia.Cast = cast;

            var director = new List<Director>();
            foreach (var item in pMedia.Director)
            {
                var dbItem = iDbContext.Directors.Where(i => Tools.Equals(i.FullName, item.FullName)).AsEnumerable();
                if (dbItem.Count() > 0)
                {
                    director.Add(dbItem.First());
                }
                else
                {
                    item.ITS = DateTime.Now;
                    director.Add(item);
                }
            }
            pMedia.Director = director;

            var genres = new List<Genre>();
            foreach (var item in pMedia.Genres)
            {
                var dbItem = iDbContext.Genres.Where(i => Tools.Equals(i.Name, item.Name)).AsEnumerable();
                if (dbItem.Count() > 0)
                {
                    genres.Add(dbItem.First());
                }
                else
                {
                    item.ITS = DateTime.Now;
                    genres.Add(item);
                }
            }
            pMedia.Genres = genres;

            var origin = new List<Country>();
            foreach (var item in pMedia.Origin)
            {
                var dbItem = iDbContext.Countries.Where(i => Tools.Equals(i.Name, item.Name)).AsEnumerable();
                if (dbItem.Count() > 0)
                {
                    origin.Add(dbItem.First());
                }
                else
                {
                    item.ITS = DateTime.Now;
                    origin.Add(item);
                }
            }
            pMedia.Origin = origin;

            var writer = new List<Writer>();
            foreach (var item in pMedia.Writer)
            {
                var dbItem = iDbContext.Writers.Where(i => Tools.Equals(i.FullName, item.FullName)).AsEnumerable();
                if (dbItem.Count() > 0)
                {
                    writer.Add(dbItem.First());
                }
                else
                {
                    item.ITS = DateTime.Now;
                    writer.Add(item);
                }
            }
            pMedia.Writer = writer;

            iDbContext.Media.Add(pMedia);
        }

        /// <summary>
        /// Actualizar una Media en la base de datos.
        /// Lanza una excepción ya que los medios son de solo lectura.
        /// </summary>
        /// <param name="pMedia">Media a actualizar.</param>
        public override void Update(Media pMedia)
        {
            throw new Exception("Media is readonly.");
        }

        /// <summary>
        /// Elimina una Media existente de la base de datos.
        /// </summary>
        /// <param name="pMedia">Media a eliminar.</param>
        public override void Delete(Media pMedia)
        {
            iDbContext.Media.Remove(pMedia);
        }

        /// <summary>
        /// Obtiene una Media de la base de datos según su identificador.
        /// </summary>
        /// <param name="pId">Identificador del media.</param>
        /// <returns>Media encontrada o null si no se encuentra.</returns>
        public override Media Get(int pId)
        {
            return iDbContext.Media.Find(pId);
        }

        /// <summary>
        /// Obtiene todas las Medias de la base de datos.
        /// </summary>
        /// <returns>Enumeración de medias.</returns>
        public override IEnumerable<Media> GetAll()
        {
            return iDbContext.Media
                .Include("Cast")
                .Include("Director")
                .Include("Genres")
                .Include("Origin")
                .Include("Writer");
        }
    }
}
