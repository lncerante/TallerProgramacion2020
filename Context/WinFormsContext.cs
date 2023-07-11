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
    /// <summary>
    /// Clase que actúa como contexto en una aplicación de Windows Forms.
    /// Permite almacenar información compartida y acceder a ella desde diferentes partes de la aplicación.
    /// </summary>
    public class WinFormsContext
    {
        protected static WinFormsContext _instance;

        protected UserDTO iUser;

        protected FormMenu iRootForm;

        protected IEnumerable<MediaDTO> iCurrentMedia;

        /// <summary>
        /// Constructor de la clase WinFormsContext. Inicializa las variables iUser y iRootForm como null.
        /// </summary>
        protected WinFormsContext()
        {
            iUser = null;
            iRootForm = null;
        }

        /// <summary>
        /// Permite acceder al contexto de la aplicación en diferentes partes del código.
        /// </summary>
        /// <returns>Retorna una instancia única de la clase "WinFormsContext". 
        /// Si no existe una instancia previa, crea una nueva instancia y la retorna.</returns>
        public static WinFormsContext GetInstance()
        {
            if (_instance == null)
            {
                _instance = new WinFormsContext();
            }
            return _instance;
        }

        /// <summary>
        /// Reinicia el contexto de la aplicación, creando una nueva instancia de la clase "WinFormsContext".
        /// </summary>
        /// <returns>Si no existe una instancia previa, crea una nueva instancia y la retorna</returns>
        public static WinFormsContext Reset()
        {
            if (_instance == null)
            {
                _instance = new WinFormsContext();
            }
            return _instance;
        }

        /// <summary>
        /// Permite acceder al objeto UserDTO que representa al usuario actual en el contexto.
        /// </summary>
        public UserDTO User
        {
            get { return iUser; }
            set { iUser = value; }
        }

        /// <summary>
        /// Permite acceder al formulario raíz de la aplicación en el contexto.
        /// </summary>
        public FormMenu RootForm
        {
            get { return iRootForm; }
            set { iRootForm = value; }
        }

        /// <summary>
        /// Permite acceder a la colección de objetos MediaDTO que representa las peliculas y series actuales en el contexto.
        /// </summary>
        public IEnumerable<MediaDTO> CurrentMedia
        {
            get { return iCurrentMedia; }
            set { iCurrentMedia = value; }
        }
    }
}
