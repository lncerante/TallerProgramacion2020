namespace TallerProgramacion2020.MediaManager.Domain
{
    internal class Country : BaseObject
    {
        protected string iName;

        public string Name
        {
            get { return iName; }
            set { iName = value; }
        }
    }
}
