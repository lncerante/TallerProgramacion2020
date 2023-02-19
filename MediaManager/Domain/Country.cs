namespace TallerProgramacion2020.MediaManager.Domain
{
    internal class Country : BaseObject
    {
        protected string iName;

        public Country(string pName)
        {
            Name = pName;
        }

        public string Name
        {
            get { return iName; }
            set { iName = value; }
        }

        public bool Equals(Country other)
        {
            return Name == other.Name;
        }
    }
}
