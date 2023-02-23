using System.Windows.Forms;
using TallerProgramacion2020.Forms;
using TallerProgramacion2020.MediaManager.DAL.EntityFramework;


namespace TallerProgramacion2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var unit = new UnitOfWork(new MediaManagerDbContext());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormManageUsers());
        }
    }
}
