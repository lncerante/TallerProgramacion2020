namespace TallerProgramacion2020.MediaManager.Domain
{
    internal class UserRole : BaseObject
    {
        protected string iName;

        public string Name
        {
            get { return iName; }
            set { iName = value; }
        }
    }
}
