using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.MediaManager.ApiAccess
{
    /// <summary>
    /// Interfaz que define métodos para buscar y obtener información de Medias.
    /// </summary>
    public interface IMediaFinder
    {
        /// <summary>
        /// Busca Medias en función del título, género, tipo y página especificados.
        /// </summary>
        /// <param name="pTitle">Título a buscar.</param>
        /// <param name="pGenre">Género a buscar (opcional).</param>
        /// <param name="pType">Tipo de media a buscar (opcional).</param>
        /// <param name="pPage">Número de página para la búsqueda (opcional).</param>
        /// <returns>Lista de medias encontrados que coinciden con los criterios de búsqueda.</returns>
        IList<Media> FindMedia(string pTitle, Genre pGenre = null, MediaType? pType = null, int pPage = 1);

        /// <summary>
        /// Obtiene una Media en función de su ID de IMDb.
        /// </summary>
        /// <param name="pImdbID">ID de IMDb de la media a obtener.</param>
        /// <returns>La Media encontrado o null si no se encuentra.</returns>
        Media GetMediaByImdbID(string pImdbID);
    }
}