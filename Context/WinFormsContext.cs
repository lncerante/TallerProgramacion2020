using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerProgramacion2020.MediaManager.DAL.EntityFramework;
using TallerProgramacion2020.MediaManager.DAL;
using TallerProgramacion2020.MediaManager.IO;
using TallerProgramacion2020.Forms;

namespace TallerProgramacion2020.WinFormsContextClass
{
    public class WinFormsContext
    {
        protected static WinFormsContext _instance;

        protected UserDTO iUser;

        protected FormMenu iRootForm;

        protected IEnumerable<MediaDTO> iCurrentMedia;

        protected WinFormsContext()
        {
            iUser = null;
            iRootForm = null;
        }

        public static WinFormsContext GetInstance()
        {
            if (_instance == null)
            {
                _instance = new WinFormsContext();
            }
            return _instance;
        }

        public static WinFormsContext Reset()
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

        public FormMenu RootForm
        {
            get { return iRootForm; }
            set { iRootForm = value; }
        }

        public IEnumerable<MediaDTO> CurrentMedia
        {
            get { return iCurrentMedia; }
            set { iCurrentMedia = value; }
        }
    }
}
