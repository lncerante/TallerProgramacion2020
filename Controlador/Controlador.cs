using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerProgramacion2020.Forms;
using TallerProgramacion2020.MediaManager.IO;

namespace TallerProgramacion2020.Controlador
{
    internal class Controlador
    {
        private string activeUser;

        // constructor de clase
        public Controlador()
        {
            activeUser = null;
        }
        
        public void inicio()
        {
            
            bool existeAdmi = new bool();
            existeAdmi = false;
            // consultar si existe un usuario tipo administador
            if (existeAdmi)
            {
                new FormSignIn();
            }
            else
            {
                new FormRegisterAdminUser();
                new FormSignIn();
            }
        }

        public bool ValidSignIn(UserDTO user)
        {
            //bool valid = false;
            bool valid = true;
            // consultar a base de dato por el usuario
            if (valid)
            {
                activeUser = user.UserName;
                return true;
            }
            else
                return false;
        }
        public void RegisterNewUser(UserDTO user)
        {
            // enviar el UserDTO a la Base de datos
            new FormMenu();

        }

    }
}
