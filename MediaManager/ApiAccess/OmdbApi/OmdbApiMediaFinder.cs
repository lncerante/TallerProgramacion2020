using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.MediaManager.ApiAccess.ImdbApi
{
    /// <summary>
    /// Clase que implementa la interfaz IMediaFinder y permite buscar y obtener Medias utilizando la API de OMDB.
    /// </summary>
    internal class OmdbApiMediaFinder : IMediaFinder
    {
        protected const string iApiUrl = "http://www.omdbapi.com/";
        protected const string iApiKey = "?apikey=8c8fc255";
        protected HttpClient iHttpClient;

        /// <summary>
        /// Constructor de la clase OmdbApiMediaFinder.
        /// Inicializa una instancia de HttpClient y establece la configuración base para realizar las solicitudes a la API de OMDB.
        /// </summary>
        public OmdbApiMediaFinder()
        {
            iHttpClient = new HttpClient();
            iHttpClient.BaseAddress = new Uri(iApiUrl);
            iHttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
        }

        /// <summary>
        /// Busca Medias utilizando el título, género, tipo y número de página especificados.
        /// </summary>
        /// <param name="pTitle">Título para la búsqueda.</param>
        /// <param name="pGenre">Género para filtrar los resultados (opcional).</param>
        /// <param name="pType">Tipo de media (Movie o Series) para filtrar los resultados (opcional).</param>
        /// <param name="pPage">Número de página para la paginación de resultados (opcional, valor predeterminado: 1).</param>
        /// <returns>Una lista de Medias encontradas según los criterios de búsqueda.</returns>
        public IList<Media> FindMedia(string pTitle, Genre pGenre = null, MediaType? pType = null, int pPage = 1)
        {
            // Construir los parámetros de la solicitud a la API de OMDB
            var parameters = iApiKey + "&s=" + pTitle + "&page=" + pPage;

            if (pType == MediaType.Movie)
            {
                parameters += "&type=movie";
            }
            else if (pType == MediaType.Series)
            {
                parameters += "&type=series";
            }

            // Realizar la solicitud a la API de OMDB
            var response = iHttpClient.GetAsync(parameters).Result;
            var mediaResponse = new List<Media>();

            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync().Result;
                /*var writer = new StreamWriter("C:/Users/User/Documents/TallerDeProgramacion/mediaFinderResults.txt", true);
                writer.WriteLine(jsonString);
                writer.Dispose();*/
                var jsSerializer = new JavaScriptSerializer();
                var mediaSearch = jsSerializer.Deserialize<OmdbApiMediaSearch>(jsonString);
                if (mediaSearch.Response == true)
                {
                    foreach (var mediaDTO in mediaSearch.Search)
                    {
                        var media = GetMediaByImdbID(mediaDTO.imdbID);
                        if (pGenre == null || media.Genres.Any(genre => genre.Equals(pGenre)))
                        {
                            mediaResponse.Add(media);
                        }
                    }
                }
            }
            return mediaResponse;
        }

        /// <summary>
        /// Obtiene una Media por su ID de IMDB.
        /// </summary>
        /// <param name="pImdbID">ID de IMDB de la media.</param>
        /// <returns>Media correspondiente al ID de IMDB especificado.</returns>
        public Media GetMediaByImdbID(string pImdbID)
        {
            // Realizar la solicitud a la API de OMDB para obtener los detalles de la Media
            var response = iHttpClient.GetAsync(iApiKey + "&i=" + pImdbID).Result;
            var mediaResponse = new Media();
            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync().Result;
                /*var writer = new StreamWriter("C:/Users/User/Documents/TallerDeProgramacion/mediaFinderResults.txt", true);
                writer.WriteLine(jsonString);
                writer.Dispose();*/
                var jsSerializer = new JavaScriptSerializer();
                var mediaDTO = jsSerializer.Deserialize<OmdbApiMediaDTO>(jsonString);
                mediaResponse = mediaDTO.AsMedia;
            }
            return mediaResponse;
        }
    }
}
