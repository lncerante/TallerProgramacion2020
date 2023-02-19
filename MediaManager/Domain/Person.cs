using System.Xml.Linq;

namespace TallerProgramacion2020.MediaManager.Domain
{
    internal class Person : BaseObject
    {
        protected string iFullName;

        public Person(string pFullName)
        {
            FullName = pFullName;
        }

        public string FullName
        {
            get { return iFullName; }
            set { iFullName = value; }
        }

        public bool Equals(Person other)
        {
            return FullName == other.FullName;
        }
    }
}
