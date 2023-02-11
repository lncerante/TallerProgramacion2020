namespace TallerProgramacion2020.MediaManager.Domain
{
    internal class Person : BaseObject
    {
        protected string iFullName;

        public string FullName
        {
            get { return iFullName; }
            set { iFullName = value; }
        }
    }
}
