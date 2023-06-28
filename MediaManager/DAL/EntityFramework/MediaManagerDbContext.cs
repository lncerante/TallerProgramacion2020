using System.Data.Entity;
using System.Data.SqlServerCe;
using TallerProgramacion2020.MediaManager.Domain;
using System.IO;
using System;
using System.Diagnostics;

namespace TallerProgramacion2020.MediaManager.DAL.EntityFramework
{
    internal class MediaManagerDbContext : DbContext
    {
        protected DbSet<Country> iCountries;
        protected DbSet<Genre> iGenres;
        protected DbSet<Media> iMedia;
        protected DbSet<Actor> iActors;
        protected DbSet<Director> iDirectors;
        protected DbSet<Writer> iWriters;
        protected DbSet<User> iUsers;
        protected DbSet<Review> iReviews;
        protected DbSet<WatchListItem> iWatchListItems;

        public MediaManagerDbContext() : base("MediaManagerDb")
        { }

        public DbSet<Country> Countries { get => iCountries; set => iCountries = value; }
        public DbSet<Genre> Genres { get => iGenres; set => iGenres = value; }
        public DbSet<Media> Media { get => iMedia; set => iMedia = value; }
        public DbSet<Actor> Actors { get => iActors; set => iActors = value; }
        public DbSet<Director> Directors { get => iDirectors; set => iDirectors = value; }
        public DbSet<Writer> Writers { get => iWriters; set => iWriters = value; }
        public DbSet<User> Users { get => iUsers; set => iUsers = value; }
        public DbSet<Review> Reviews { get => iReviews; set => iReviews = value; }
        public DbSet<WatchListItem> WatchListItems { get => iWatchListItems; set => iWatchListItems = value; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Media>()
                .HasMany<Country>(m => m.Origin)
                .WithMany(c => c.Media);

            modelBuilder.Entity<Media>()
                .HasMany<Genre>(m => m.Genres)
                .WithMany(c => c.Media);

            modelBuilder.Entity<Media>()
                .HasMany<Actor>(m => m.Cast)
                .WithMany(c => c.Media);

            modelBuilder.Entity<Media>()
                .HasMany<Director>(m => m.Director)
                .WithMany(c => c.Media);

            modelBuilder.Entity<Media>()
                .HasMany<Writer>(m => m.Writer)
                .WithMany(c => c.Media);

            modelBuilder.Entity<User>()
                .Property(a => a.ProfilePhoto)
                .HasColumnType("image")
                .IsMaxLength();

            modelBuilder.Entity<Media>()
                .Property(a => a.Poster)
                .HasColumnType("image")
                .IsMaxLength();
        }
    }
}
