using TallerProgramacion2020.MediaManager.DAL.EntityFramework;


namespace TallerProgramacion2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var unit = new UnitOfWork(new MediaManagerDbContext());
        }
    }
}
