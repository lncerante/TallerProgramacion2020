using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using TallerProgramacion2020.MediaManager.DAL.EntityFramework;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.Test.MediaManagerTests.DALTests.EntityFrameworkTests
{
    [TestClass]
    public class MediaRepositoryTests
    {
        private Media GetTestMedia()
        {
            var genres = new List<Genre>
            {
                new Genre("genre")
            };
            var countries = new List<Country>
            {
                new Country("country")
            };
            var cast = new List<Actor>
            {
                new Actor("actor")
            };
            var director = new List<Director>
            {
                new Director("director")
            };
            var writer = new List<Writer>
            {
                new Writer("writer")
            };
            Media media = new Media
            {
                ImdbID = "imdbid_test",
                Title = "Test Movie",
                Year = "2023",
                MediaType = MediaType.Movie,
                ReleaseDate = DateTime.Now,
                Genres = genres,
                RuntimeInMin = 90,
                Director = director,
                Origin = countries,
                Writer = writer,
                Cast = cast,
                Poster = null,
                ImdbRating = (float)7.2
            };
            return media;
        }

        [TestMethod]
        [DoNotParallelize]
        public void Test_CreateMedia()
        {
            if (File.Exists("./MediaManagerDbTest.sdf"))
            {
                File.Delete("./MediaManagerDbTest.sdf");
            }
            // Arrange
            var dbContext = new MediaManagerDbContext();
            dbContext.Database.Initialize(true);
            dbContext.SaveChanges();
            var mediaRepository = new MediaRepository(dbContext);
            var media = GetTestMedia();

            // Act
                // Create
            mediaRepository.Create(media);
            dbContext.SaveChanges();
            dbContext.Dispose();
                // Fetch
            dbContext = new MediaManagerDbContext();
            mediaRepository = new MediaRepository(dbContext);
            var dbMedia = mediaRepository.GetAll().Single(m => m.ImdbID == "imdbid_test");

            // Assert
            Assert.IsNotNull(dbMedia);
            Assert.IsTrue(dbMedia.ID != null && dbMedia.ID == 1);
            Assert.IsTrue(dbMedia.ImdbID == "imdbid_test");
            Assert.IsTrue(dbMedia.ITS != null && dbMedia.ITS?.Date == DateTime.Now.Date);
            Assert.IsTrue(dbMedia.Title == "Test Movie");
            Assert.IsTrue(dbMedia.Year == "2023");
            Assert.IsTrue(dbMedia.MediaType == MediaType.Movie);
            Assert.IsTrue(dbMedia.ReleaseDate != null && dbMedia.ReleaseDate?.Date == DateTime.Now.Date);
            Assert.IsTrue(dbMedia.RuntimeInMin == 90);
            Assert.IsTrue(dbMedia.Genres.All(i => i.Name == "genre"));
            Assert.IsTrue(dbMedia.Origin.All(i => i.Name == "country"));
            Assert.IsTrue(dbMedia.Cast.All(i => i.FullName == "actor"));
            Assert.IsTrue(dbMedia.Director.All(i => i.FullName == "director"));
            Assert.IsTrue(dbMedia.Writer.All(i => i.FullName == "writer"));
            Assert.IsTrue(dbMedia.Poster == null);
            Assert.IsTrue(dbMedia.ImdbRating == media.ImdbRating);
            dbContext.Database.Delete();
            dbContext.SaveChanges();
            dbContext.Dispose();
        }

        [TestMethod]
        [DoNotParallelize]
        public void Test_DeleteMedia()
        {
            if (File.Exists("./MediaManagerDbTest.sdf"))
            {
                File.Delete("./MediaManagerDbTest.sdf");
            }
            // Arrange
            var dbContext = new MediaManagerDbContext();
            dbContext.Database.Initialize(true);
            dbContext.SaveChanges();
            var mediaRepository = new MediaRepository(dbContext);
            var media = GetTestMedia();

            // Act
                // Create
            mediaRepository.Create(media);
            dbContext.SaveChanges();
            dbContext.Dispose();
                // Delete
            dbContext = new MediaManagerDbContext();
            mediaRepository = new MediaRepository(dbContext);
            media = mediaRepository.GetAll().Single(m => m.ImdbID == "imdbid_test");
            mediaRepository.Delete(media);
            dbContext.SaveChanges();
            dbContext.Dispose();
                // Fetch
            dbContext = new MediaManagerDbContext();
            mediaRepository = new MediaRepository(dbContext);
            var dbMedia = mediaRepository.GetAll();

            // Assert
            Assert.IsNotNull(dbMedia);
            Assert.IsTrue(dbMedia.Count() == 0);
            dbContext.Database.Delete();
            dbContext.SaveChanges();
            dbContext.Dispose();
        }

        [TestMethod]
        [DoNotParallelize]
        public void Test_GetMedia()
        {
            if (File.Exists("./MediaManagerDbTest.sdf"))
            {
                File.Delete("./MediaManagerDbTest.sdf");
            }
            // Arrange
            var dbContext = new MediaManagerDbContext();
            dbContext.Database.Initialize(true);
            dbContext.SaveChanges();
            var mediaRepository = new MediaRepository(dbContext);
            var media = GetTestMedia();

            // Act
                // Create
            mediaRepository.Create(media);
            dbContext.SaveChanges();
            dbContext.Dispose();
                // Fetch
            dbContext = new MediaManagerDbContext();
            mediaRepository = new MediaRepository(dbContext);
            var dbMedia = mediaRepository.Get(1);

            // Assert
            Assert.IsNotNull(dbMedia);
            Assert.IsTrue(dbMedia.ID == 1);
            Assert.IsTrue(dbMedia.Title == "Test Movie");
            dbContext.Database.Delete();
            dbContext.SaveChanges();
            dbContext.Dispose();
        }

        [TestMethod]
        [DoNotParallelize]
        public void Test_GetWhereMedia()
        {
            if (File.Exists("./MediaManagerDbTest.sdf"))
            {
                File.Delete("./MediaManagerDbTest.sdf");
            }
            // Arrange
            var dbContext = new MediaManagerDbContext();
            dbContext.Database.Initialize(true);
            dbContext.SaveChanges();
            var mediaRepository = new MediaRepository(dbContext);
            var media = GetTestMedia();

            List<Func<Media, bool>> conditionsRight = new List<Func<Media, bool>>();
            List<Func<Media, bool>> conditionsWrong = new List<Func<Media, bool>>();
            conditionsRight.Add(m => m.MediaType == MediaType.Movie);
            conditionsWrong.Add(m => m.MediaType == MediaType.Series);

            // Act
                // Create
            mediaRepository.Create(media);
            dbContext.SaveChanges();
            dbContext.Dispose();
                // Fetch
            dbContext = new MediaManagerDbContext();
            mediaRepository = new MediaRepository(dbContext);
            var dbMediaRight = mediaRepository.GetWhere(conditionsRight);
            var dbMediaWrong = mediaRepository.GetWhere(conditionsWrong);

            // Assert
            Assert.IsTrue(dbMediaRight.Count() == 1);
            Assert.IsTrue(dbMediaWrong.Count() == 0);
            dbContext.Database.Delete();
            dbContext.SaveChanges();
            dbContext.Dispose();
        }
    }
}
