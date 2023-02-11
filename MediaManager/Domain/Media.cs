using System;
using System.Collections.Generic;

namespace TallerProgramacion2020.MediaManager.Domain
{
    internal class Media : BaseObject
    {
        protected string iImdbID;
        protected string iTitle;
        protected string iYear;
        protected MediaType iMediaType;
        protected DateTime iReleaseDate;
        protected IList<Genre> iGenres;
        protected int iRuntimeInMin;
        protected IList<Person> iDirector;
        protected IList<Person> iWriter;
        protected IList<Person> iCast;
        protected IList<Country> iOrigin;
        protected Byte[] iPoster;
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
        public DateTime ReleaseDate
        {
            get { return iReleaseDate; }
            set { iReleaseDate = value; }
        }
        public IList<Genre> Genres
        {
            get { return iGenres; }
            set { iGenres = value; }
        }
        public int RuntimeInMin
        {
            get { return iRuntimeInMin; }
            set { iRuntimeInMin = value; }
        }
        public IList<Person> Director
        {
            get { return iDirector; }
            set { iDirector = value; }
        }
        public IList<Person> Writer
        {
            get { return iWriter; }
            set { iWriter = value; }
        }
        public IList<Person> Cast
        {
            get { return iCast; }
            set { iCast = value; }
        }
        public IList<Country> Origin
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
    }
}
