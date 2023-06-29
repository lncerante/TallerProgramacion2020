using System;
using System.Collections.Generic;
using System.Xml.Linq;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.MediaManager.IO
{
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


        public string ImdbID
        {
            get { return iImdbID; }
            set { iImdbID = value; }
        }
        public string Title
        {
            get { return iTitle; }
            set { iTitle = value; }
        }
        public string Year
        {
            get { return iYear; }
            set { iYear = value; }
        }
        public MediaType MediaType
        {
            get { return iMediaType; }
            set { iMediaType = value; }
        }
        public DateTime? ReleaseDate
        {
            get { return iReleaseDate; }
            set { iReleaseDate = value; }
        }
        public IEnumerable<GenreDTO> Genres
        {
            get { return iGenres; }
            set { iGenres = value; }
        }
        public int RuntimeInMin
        {
            get { return iRuntimeInMin; }
            set { iRuntimeInMin = value; }
        }
        public IEnumerable<DirectorDTO> Director
        {
            get { return iDirector; }
            set { iDirector = value; }
        }
        public IEnumerable<WriterDTO> Writer
        {
            get { return iWriter; }
            set { iWriter = value; }
        }
        public IEnumerable<ActorDTO> Cast
        {
            get { return iCast; }
            set { iCast = value; }
        }
        public IEnumerable<CountryDTO> Origin
        {
            get { return iOrigin; }
            set { iOrigin = value; }
        }
        public Byte[] Poster
        {
            get { return iPoster; }
            set { iPoster = value; }
        }
        public float ImdbRating
        {
            get { return iImdbRating; }
            set { iImdbRating = value; }
        }

        public bool Equals(MediaDTO other)
        {
            return ImdbID == other.ImdbID;
        }
    }
}
