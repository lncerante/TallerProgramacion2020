using System;
using System.Collections.Generic;
using System.Xml.Linq;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.MediaManager.IO
{
    /// <summary>
    /// Clase que representa un objeto de transferencia de datos de una película o serie.
    /// Hereda de la clase "BaseObjectDTO".
    /// </summary>
    public class MediaDTO : BaseObjectDTO
    {
        protected string iImdbID;
        protected string iTitle;
        protected string iYear;
        protected MediaType iMediaType;
        protected DateTime? iReleaseDate;
        protected IEnumerable<GenreDTO> iGenres;
        protected int iRuntimeInMin;
        protected IEnumerable<DirectorDTO> iDirector;
        protected IEnumerable<WriterDTO> iWriter;
        protected IEnumerable<ActorDTO> iCast;
        protected IEnumerable<CountryDTO> iOrigin;
        protected byte[] iPoster;
        protected float iImdbRating;

        /// <summary>
        /// Id de IMDB de la película o serie.
        /// </summary>
        public string ImdbID
        {
            get { return iImdbID; }
            set { iImdbID = value; }
        }
        /// <summary>
        /// Título de la película o serie..
        /// </summary>
        public string Title
        {
            get { return iTitle; }
            set { iTitle = value; }
        }
        /// <summary>
        /// Año de lanzamiento de la película o serie.
        /// </summary>
        public string Year
        {
            get { return iYear; }
            set { iYear = value; }
        }

        /// <summary>
        /// Tipo de media.
        /// </summary>
        public MediaType MediaType
        {
            get { return iMediaType; }
            set { iMediaType = value; }
        }

        /// <summary>
        /// Fecha de lanzamiento de la película o serie.
        /// </summary>
        public DateTime? ReleaseDate
        {
            get { return iReleaseDate; }
            set { iReleaseDate = value; }
        }

        /// <summary>
        /// Géneros de la película o serie.
        /// </summary>
        public IEnumerable<GenreDTO> Genres
        {
            get { return iGenres; }
            set { iGenres = value; }
        }

        /// <summary>
        /// Duración en minutos de la película o serie.
        /// </summary>
        public int RuntimeInMin
        {
            get { return iRuntimeInMin; }
            set { iRuntimeInMin = value; }
        }

        /// <summary>
        /// Directores de la película o serie.
        /// </summary>
        public IEnumerable<DirectorDTO> Director
        {
            get { return iDirector; }
            set { iDirector = value; }
        }

        /// <summary>
        /// Escritores de la película o serie.
        /// </summary>
        public IEnumerable<WriterDTO> Writer
        {
            get { return iWriter; }
            set { iWriter = value; }
        }

        /// <summary>
        /// Actores de la película o serie.
        /// </summary>
        public IEnumerable<ActorDTO> Cast
        {
            get { return iCast; }
            set { iCast = value; }
        }

        /// <summary>
        /// Países de origen de la película o serie.
        /// </summary>
        public IEnumerable<CountryDTO> Origin
        {
            get { return iOrigin; }
            set { iOrigin = value; }
        }

        /// <summary>
        /// Póster del medio.
        /// </summary>
        public Byte[] Poster
        {
            get { return iPoster; }
            set { iPoster = value; }
        }

        /// <summary>
        /// Calificación de IMDB de la película o serie.
        /// </summary>
        public float ImdbRating
        {
            get { return iImdbRating; }
            set { iImdbRating = value; }
        }

        /// <summary>
        /// Compara si dos objetos de tipo "MediaDTO" son iguales basándose en el id IMDB.
        /// </summary>
        /// <param name="other">Objeto "MediaDTO" a comparar.</param>
        /// <returns>True si los objetos son iguales, False en caso contrario.</returns>
        public bool Equals(MediaDTO other)
        {
            return ImdbID == other.ImdbID;
        }
    }
}
