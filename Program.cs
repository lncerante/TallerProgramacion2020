using System;
using System.Windows.Forms;
using TallerProgramacion2020.MediaManager.Controllers;
using System.Globalization;

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
            
            new SignInController().Run();
        }
    }
}
