using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TallerProgramacion2020.MediaManager.ApiAccess.ImdbApi;

namespace TallerProgramacion2020.Test.MediaManagerTests.ApiAccessTests.OmbdbApiTests
{
    /// <summary>
    /// Clase de pruebas unitarias para verificar la funcionalidad de la clase OmdbApiRequestClient,
    /// que realiza solicitudes a la API de OMDB para buscar y obtener información sobre Medias.
    /// </summary>
    [TestClass]
    public class OmdbApiRequestClientTests
    {
        /// <summary>
        /// Verifica si el método MultipleMediaRequest realiza una solicitud exitosa
        /// a la API de OMDB y devuelve una respuesta válida para una búsqueda válida.
        /// </summary>
        [TestMethod]
        public void Test_MultipleMediaRequest_HappyPath()
        {
            // Arrange
            var client = new OmdbApiRequestClient();
            var title = "The Matrix";

            // Act
            string jsonResponse = client.MultipleMediaRequest(title);

            // Assert
            Assert.IsNotNull(jsonResponse);
            Assert.IsTrue(jsonResponse.Contains("Search"));
        }

        /// <summary>
        /// Verifica si el método MultipleMediaRequest devuelve una Response False
        /// para una búsqueda con un título inválido en la API de OMDB.
        /// </summary>
        [TestMethod]
        public void Test_MultipleMediaRequest_InvalidTitle()
        {
            // Arrange
            var client = new OmdbApiRequestClient();
            var invalidTitle = "Invalid Title, movie or series doesn't exist";

            // Act
            string jsonResponse = client.MultipleMediaRequest(invalidTitle);

            // Assert
            Assert.IsTrue(jsonResponse.Contains("\"Response\":\"False\""));
        }

        /// <summary>
        /// Verifica si el método SingleMediaRequest realiza una solicitud exitosa
        /// a la API de OMDB y devuelve una respuesta válida para un ID de IMDB válido.
        /// </summary>
        [TestMethod]
        public void Test_SingleMediaRequest_HappyPath()
        {
            // Arrange
            var client = new OmdbApiRequestClient();
            var imdbID = "tt0133093";

            // Act
            string jsonResponse = client.SingleMediaRequest(imdbID);

            // Assert
            Assert.IsNotNull(jsonResponse);
            Assert.IsTrue(jsonResponse.Contains("Title"));
            Assert.IsTrue(jsonResponse.Contains("The Matrix"));
        }

        /// <summary>
        /// Verifica si el método SingleMediaRequest devuelve una Response False
        /// para un ID de IMDB inválido en la API de OMDB.
        /// </summary>
        [TestMethod]
        public void Test_SingleMediaRequest_InvalidImdbID()
        {
            // Arrange
            var client = new OmdbApiRequestClient();
            var invalidImdbID = "invalid_id";

            // Act
            string jsonResponse = client.SingleMediaRequest(invalidImdbID);

            // Assert
            Assert.IsTrue(jsonResponse.Contains("\"Response\":\"False\""));
        }
    }
}
