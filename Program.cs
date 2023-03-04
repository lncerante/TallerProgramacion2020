using System;
using System.Windows.Forms;
using TallerProgramacion2020.Forms;
using TallerProgramacion2020.MediaManager.DAL.EntityFramework;


namespace TallerProgramacion2020
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            var unit = new UnitOfWork(new MediaManagerDbContext());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormSearchMoviesOrSeries());

            FormSignIn formSignIn = new FormSignIn();
            Application.Run(formSignIn);
            if (formSignIn.userSuccessfullyAuthenticated)
            {
                Application.Run(new FormMenu(formSignIn.adminUser));
            }

        }
    }
}
