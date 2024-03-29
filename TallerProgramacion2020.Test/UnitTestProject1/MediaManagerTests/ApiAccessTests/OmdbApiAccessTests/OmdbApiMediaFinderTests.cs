﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using TallerProgramacion2020.MediaManager.ApiAccess.ImdbApi;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.Test.MediaManagerTests.ApiAccessTests.OmdbApiAccessTests
{
    /// <summary>
    /// Clase de pruebas unitarias para verificar la funcionalidad de la clase OmdbApiMediaFinder
    /// para buscar y obtener Medias utilizando la API de OMDB.
    /// </summary>
    [TestClass]
    public class OmdbApiMediaFinderTests
    {
        /// <summary>
        /// Verifica si el método FindMedia devuelve una lista de Medias
        /// que coinciden con el título, género y tipo de media especificados.
        /// </summary>
        [TestMethod]
        public void Test_FindMedia_HappyPath()
        {
            // Arrange
            var finder = new OmdbApiMediaFinder();
            var title = "The Matrix";
            var genre = new Genre("Action");
            var type = MediaType.Movie;

            // Act
            IList<Media> medias = finder.FindMedia(title, genre, type);

            // Assert
            Assert.IsTrue(medias.All(m => m.Title.Contains(title)));
            Assert.IsTrue(medias.All(m => m.Genres.Any(g => g.Name == genre.Name)));
            Assert.IsTrue(medias.All(m => m.MediaType == type));
        }

        /// <summary>
        /// Verificar si el método FindMedia devuelve una lista vacía
        /// cuando se busca un título que no existe en la API de OMDB.
        /// </summary>
        [TestMethod]
        public void Test_FindMedia_Empty()
        {
            // Arrange
            var finder = new OmdbApiMediaFinder();
            var title = "Movie Or Series Doesn't Exist";

            // Act
            IList<Media> medias = finder.FindMedia(title);

            // Assert
            Assert.IsTrue(medias.Count == 0);
        }

        /// /// <summary>
        /// Verificar si el método GetMediaByImdbID devuelve una Media
        /// que coincide con el IMDb ID de media especificado.
        /// </summary>
        [TestMethod]
        public void Test_GetMediaByImdbID_HappyPath()
        {
            // Arrange
            var finder = new OmdbApiMediaFinder();
            var imdbID = "tt0133093";
            var title = "The Matrix";
            var type = MediaType.Movie;

            // Act
            Media media = finder.GetMediaByImdbID(imdbID);

            // Assert
            Assert.AreEqual(imdbID, media.ImdbID);
            Assert.AreEqual(title, media.Title);
            Assert.AreEqual(type, media.MediaType);
        }

    }
}
