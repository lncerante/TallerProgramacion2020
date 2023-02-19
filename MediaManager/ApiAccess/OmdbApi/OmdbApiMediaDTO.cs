using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.MediaManager.ApiAccess.ImdbApi
{
    internal class OmdbApiMediaDTO
    {
        protected static string[] iSeparator = { ", " };
        public string Title;
        public string Year;
        public string Released;
        public string Runtime;
        public string Genre;
        public string Director;
        public string Writer;
        public string Actors;
        public string Country;
        public string Poster;
        public string imdbID;
        public string imdbRating;
        public string Type;

        public Media AsMedia
        {
            get
            {
                var media = new Media();

                media.ImdbID = imdbID;
                media.Title = Title;
                media.Year = Year;

                if (Released != "N/A")
                    media.ReleaseDate = DateTime.Parse(Released);
                if (Runtime != "N/A")
                    media.RuntimeInMin = int.Parse(new String(Runtime.TakeWhile(Char.IsDigit).ToArray()));
                if (imdbRating != "N/A")
                    media.ImdbRating = float.Parse(imdbRating, CultureInfo.InvariantCulture);
                if (Poster != "N/A")
                    media.Poster = (new WebClient()).DownloadData(Poster);
                // Para guardar la imagen en un archivo:
                // var writer = new BinaryWriter(File.OpenWrite("C:\\Users\\BOM-038\\Documents\\Dune.png"));
                // writer.Write(media.Poster);

                if (Type == "movie")
                {
                    media.MediaType = MediaType.Movie;
                }
                else if (Type == "series")
                {
                    media.MediaType = MediaType.Series;
                }

                var genresDTO = Genre.Split(iSeparator, StringSplitOptions.RemoveEmptyEntries);
                var genres = new List<Genre>();
                foreach (var genreDTO in genresDTO)
                {
                    genres.Add(new Genre(genreDTO));
                }
                media.Genres = genres;

                var countriesDTO = Country.Split(iSeparator, StringSplitOptions.RemoveEmptyEntries);
                var countries = new List<Country>();
                foreach (var countryDTO in countriesDTO)
                {
                    countries.Add(new Country(countryDTO));
                }
                media.Origin = countries;

                var directorsDTO = Director.Split(iSeparator, StringSplitOptions.RemoveEmptyEntries);
                var directors = new List<Person>();
                foreach (var directorDTO in directorsDTO)
                {
                    directors.Add(new Person(directorDTO));
                }
                media.Director = directors;

                var writersDTO = Writer.Split(iSeparator, StringSplitOptions.RemoveEmptyEntries);
                var writers = new List<Person>();
                foreach (var writerDTO in writersDTO)
                {
                    writers.Add(new Person(writerDTO));
                }
                media.Writer = writers;

                var castDTO = Actors.Split(iSeparator, StringSplitOptions.RemoveEmptyEntries);
                var cast = new List<Person>();
                foreach (var actorDTO in castDTO)
                {
                    cast.Add(new Person(actorDTO));
                }
                media.Cast = cast;

                return media;
            }
        }
    }
}
