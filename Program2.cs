using System;
using System.Collections.Generic;
using System.Linq;
using TallerProgramacion2020.MediaManager.ApiAccess.ImdbApi;
using TallerProgramacion2020.MediaManager.DAL.EntityFramework;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020
{
    class Program2
    {
        static void Main(string[] args)
        {
            var unit = new UnitOfWork(new MediaManagerDbContext());
            var mediaFinder = new OmdbApiMediaFinder();
            //mediaFinder.GetMediaByTitle("Dune");
            var results = mediaFinder.FindMedia("Dune", MediaType.Movie, new Genre("Action"));
            var a = Console.Read();
            var user = new User();
            user.ITS = DateTime.UtcNow;
            user.UserName = "lucien";
            user.PasswordHash = "123456";
            user.UserRole = UserRole.Admin;
            unit.UserRepository.Create(user);
            unit.Complete();
            Console.WriteLine("asd");
        }
    }
}