using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.MediaManager.ApiAccess.ImdbApi
{
    /// <summary>
    /// Clase que representa los resultados de búsqueda de Medias utilizando la API de OMDB.
    /// </summary>
    internal class OmdbApiMediaSearch
    {
        public IEnumerable<OmdbApiMediaDTO> Search;
        public string totalResults;
        public bool Response;
    }
}
