using System;
using System.Windows.Forms;
using TallerProgramacion2020.MediaManager.Controllers;
using TallerProgramacion2020.Forms;
using TallerProgramacion2020.MediaManager.DAL.EntityFramework;


namespace TallerProgramacion2020
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            new SignInController().Run();
            //if (formSignIn.userSuccessfullyAuthenticated)
            //{
              //Application.Run(new FormSignIn());
            //}

        }
    }
}
