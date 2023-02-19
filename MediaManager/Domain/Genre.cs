namespace TallerProgramacion2020.MediaManager.Domain
{
    internal class Genre : BaseObject
    {
        protected string iName;

        public Genre(string pName)
        { 
            Name = pName;
        }

        public string Name
        {
            get { return iName; }
            set { iName = value; }
        }

        public bool Equals(Genre other)
        {
            return Name == other.Name;
        }
    }
}
