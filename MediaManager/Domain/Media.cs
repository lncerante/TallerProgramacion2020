using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TallerProgramacion2020.MediaManager.Domain
{
    /// <summary>
    /// Clase que representa una película o serie.
    /// </summary>
    public class Media
    {
        protected int? iID;
        protected DateTime? iITS;
        protected DateTime? iUTS;
        protected DateTime? iDTS;
        protected string iImdbID;
        protected string iTitle;
        protected string iYear;
        protected MediaType iMediaType;
        protected DateTime? iReleaseDate;
        protected ICollection<Genre> iGenres;
        protected int iRuntimeInMin;
        protected ICollection<Director> iDirector;
        protected ICollection<Writer> iWriter;
        protected ICollection<Actor> iCast;
        protected ICollection<Country> iOrigin;
        protected byte[] iPoster;
        protected float iImdbRating;

        /// <summary>
        /// Id de la película o serie
        /// </summary>
        public int? ID
        {
            get { return iID; }
            set { iID = value; }
        }

        /// <summary>
        /// Fecha de creación de la película o serie.
        /// </summary>
        public DateTime? ITS
        {
            get { return iITS; }
            set { iITS = value; }
        }

        /// <summary>
        /// Fecha de última modificación de la película o serie.
        /// </summary>
        public DateTime? UTS
        {
            get { return iUTS; }
            set { iUTS = value; }
        }

        /// <summary>
        /// Fecha de eliminación de la película o serie.
        /// </summary>
        public DateTime? DTS
        {
            get { return iDTS; }
            set { iDTS = value; }
        }

        /// <summary>
        /// ID de IMDb de la película o serie.
        /// </summary>
        public string ImdbID
        {
            get { return iImdbID; }
            set { iImdbID = value; }
        }

        /// <summary>
        /// Titulo de la película o serie.
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
        /// Tipo de medio (película o serie).
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
        /// Generos asociados a la película o serie.
        /// </summary>
        public ICollection<Genre> Genres
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
        /// Directores asociados a la película o serie.
        /// </summary>
        public ICollection<Director> Director
        {
            get { return iDirector; }
            set { iDirector = value; }
        }

        /// <summary>
        /// Escritores asociados a la película o serie.
        /// </summary>
        public ICollection<Writer> Writer
        {
            get { return iWriter; }
            set { iWriter = value; }
        }

        /// <summary>
        /// Actores / actrices en el elenco de la película o serie.
        /// </summary>
        public ICollection<Actor> Cast
        {
            get { return iCast; }
            set { iCast = value; }
        }

        /// <summary>
        /// Países de origen de la película o serie.
        /// </summary>
        public ICollection<Country> Origin
        {
            get { return iOrigin; }
            set { iOrigin = value; }
        }

        /// <summary>
        /// Póster de la película o serie en formato de bytes.
        /// </summary>
        public Byte[] Poster
        {
            get { return iPoster; }
            set { iPoster = value; }
        }

        /// <summary>
        /// Calificación de IMDb de la película o serie.
        /// </summary>
        public float ImdbRating
        {
            get { return iImdbRating; }
            set { iImdbRating = value; }
        }

        /// <summary>
        /// Compara si el ID de IMDb de este medio es igual al de otro medio.
        /// </summary>
        /// <param name="other">Película o serie a comparar.</param>
        /// <returns>Retorna true si los ID de IMDb son iguales, false en caso contrario.</returns>
        public bool Equals(Media other)
        {
            return ImdbID == other.ImdbID;
        }
    }
}
