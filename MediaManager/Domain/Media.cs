using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace TallerProgramacion2020.MediaManager.Domain
{
    internal class Media
    {
        protected int? iID;
        protected DateTime? iITS;
        protected DateTime? iUTS;
        protected DateTime? iDTS;
        protected string iImdbID;
        protected string iTitle;
        protected string iYear;
        protected MediaType iMediaType;
        protected DateTime iReleaseDate;
        protected ICollection<Genre> iGenres;
        protected int iRuntimeInMin;
        protected ICollection<Director> iDirector;
        protected ICollection<Writer> iWriter;
        protected ICollection<Actor> iCast;
        protected ICollection<Country> iOrigin;
        protected Byte[] iPoster;
        protected float iImdbRating;

        public int? ID
        {
            get { return iID; }
            set { iID = value; }
        }

        public DateTime? ITS
        {
            get { return iITS; }
            set { iITS = value; }
        }

        public DateTime? UTS
        {
            get { return iUTS; }
            set { iUTS = value; }
        }

        public DateTime? DTS
        {
            get { return iDTS; }
            set { iDTS = value; }
        }


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
        public DateTime ReleaseDate
        {
            get { return iReleaseDate; }
            set { iReleaseDate = value; }
        }
        public ICollection<Genre> Genres
        {
            get { return iGenres; }
            set { iGenres = value; }
        }
        public int RuntimeInMin
        {
            get { return iRuntimeInMin; }
            set { iRuntimeInMin = value; }
        }
        public ICollection<Director> Director
        {
            get { return iDirector; }
            set { iDirector = value; }
        }
        public ICollection<Writer> Writer
        {
            get { return iWriter; }
            set { iWriter = value; }
        }
        public ICollection<Actor> Cast
        {
            get { return iCast; }
            set { iCast = value; }
        }
        public ICollection<Country> Origin
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

        public bool Equals(Media other)
        {
            return ImdbID == other.ImdbID;
        }
    }
}
