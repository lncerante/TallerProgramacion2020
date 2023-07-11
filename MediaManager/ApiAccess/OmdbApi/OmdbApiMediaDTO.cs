using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.MediaManager.ApiAccess.ImdbApi
{
    /// <summary>
    /// Clase que representa los datos transferidos desde la API de OMDB para una Media.
    /// </summary>
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

        /// <summary>
        /// Convierte la instancia de OmdbApiMediaDTO en un objeto Media.
        /// </summary>
        public Media AsMedia
        {
            get
            {
                // Crear una instancia de Media con los datos de OmdbApiMediaDTO
                var media = new Media
                {
                    ImdbID = imdbID,
                    Title = Title,
                    Year = Year
                };
                // Convertir los campos adicionales en propiedades de Media
                if (!string.IsNullOrEmpty(Released) && Released != "N/A")
                    media.ReleaseDate = DateTime.Parse(Released);
                if (!string.IsNullOrEmpty(Runtime) && Runtime != "N/A")
                    media.RuntimeInMin = int.Parse(new string(Runtime.TakeWhile(char.IsDigit).ToArray()));
                if (!string.IsNullOrEmpty(imdbRating) && imdbRating != "N/A")
                    media.ImdbRating = float.Parse(imdbRating, CultureInfo.InvariantCulture);
                if (!string.IsNullOrEmpty(Poster) && Poster != "N/A")
                    try
                    {
                        media.Poster = new WebClient().DownloadData(Poster);
                    }
                    catch { }
                if (Type == "movie")
                {
                    media.MediaType = MediaType.Movie;
                }
                else if (Type == "series")
                {
                    media.MediaType = MediaType.Series;
                }

                // Convertir las listas de géneros, países, directores, escritores y actores
                // en las respectivas listas de objetos (Genre, Country, Director, Writer, Actor)
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
                var directors = new List<Director>();
                foreach (var directorDTO in directorsDTO)
                {
                    directors.Add(new Director(directorDTO));
                }
                media.Director = directors;

                var writersDTO = Writer.Split(iSeparator, StringSplitOptions.RemoveEmptyEntries);
                var writers = new List<Writer>();
                foreach (var writerDTO in writersDTO)
                {
                    writers.Add(new Writer(writerDTO));
                }
                media.Writer = writers;

                var castDTO = Actors.Split(iSeparator, StringSplitOptions.RemoveEmptyEntries);
                var cast = new List<Actor>();
                foreach (var actorDTO in castDTO)
                {
                    cast.Add(new Actor(actorDTO));
                }
                media.Cast = cast;

                return media;
            }
        }
    }
}
