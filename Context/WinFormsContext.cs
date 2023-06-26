using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerProgramacion2020.MediaManager.DAL.EntityFramework;
using TallerProgramacion2020.MediaManager.DAL;
using TallerProgramacion2020.MediaManager.IO;

namespace TallerProgramacion2020.WinFormsContextClass
{
    public class WinFormsContext
    {
        protected static WinFormsContext _instance;

        protected UserDTO iUser;

        protected WinFormsContext()
        {
            iUser = null;
        }

        public static WinFormsContext GetInstance()
        {
            if (_instance == null)
            {
                _instance = new WinFormsContext();
            }
            return _instance;
        }

        public UserDTO User
        {
            get { return iUser; }
            set { iUser = value; }
        }
    }
}
