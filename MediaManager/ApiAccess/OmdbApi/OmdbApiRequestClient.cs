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
    internal class OmdbApiRequestClient
    {
        protected const string iApiUrl = "http://www.omdbapi.com/";
        protected const string iApiKey = "?apikey=8c8fc255";
        protected HttpClient iHttpClient;

        /// <summary>
        /// Constructor de la clase OmdbApiRequest.
        /// Inicializa una instancia de HttpClient y establece la configuración base para realizar las solicitudes a la API de OMDB.
        /// </summary>
        public OmdbApiRequestClient()
        {
            iHttpClient = new HttpClient();
            iHttpClient.BaseAddress = new Uri(iApiUrl);
            iHttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
        }

        /// <summary>
        /// Realiza un llamado a la API de OMDB para buscar medias según
        /// el título, tipo y número de página especificados.
        /// </summary>
        /// <param name="pTitle">Título para la búsqueda.</param>
        /// <param name="pType">Tipo de media (Movie o Series) para filtrar los resultados (opcional).</param>
        /// <param name="pPage">Número de página para la paginación de resultados (opcional, valor predeterminado: 1).</param>
        /// <returns>Una string en formato JSON que representa las Medias encontradas por la API.</returns>
        public string MultipleMediaRequest(string pTitle, MediaType? pType = null, int pPage = 1)
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

            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync().Result;

                return jsonString;
            }
            return null;
        }

        /// <summary>
        /// Realiza un llamado a la API de OMDB para obtener una Media en formato JSON según su ID de IMDB.
        /// </summary>
        /// <param name="pImdbID">ID de IMDB de la media.</param>
        /// <returns>Una string en formato JSON que representa la Media encontrada por la API.</returns>
        public string SingleMediaRequest(string pImdbID)
        {
            // Realizar la solicitud a la API de OMDB para obtener los detalles de la Media
            var response = iHttpClient.GetAsync(iApiKey + "&i=" + pImdbID).Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }
            return null;
        }
    }
}
