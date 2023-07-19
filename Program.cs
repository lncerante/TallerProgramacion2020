using System;
using System.Windows.Forms;
using TallerProgramacion2020.MediaManager.Controllers;
using System.Globalization;
using TallerProgramacion2020.Forms;

namespace TallerProgramacion2020
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (new SignInController().AdminExists())
            {
                Application.Run(new FormSignIn());
            }
            else
            {
                Application.Run(new FormRegisterAdminUser());
            }
        }
    }
}
