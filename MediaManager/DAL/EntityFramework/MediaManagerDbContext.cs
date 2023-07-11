using System.Data.Entity;
using System.Data.SqlServerCe;
using TallerProgramacion2020.MediaManager.Domain;
using System.IO;
using System;
using System.Diagnostics;

namespace TallerProgramacion2020.MediaManager.DAL.EntityFramework
{
    /// <summary>
    /// Clase interna que hereda de DbContext y representa el contexto de la base de datos para MediaManager.
    /// Proporciona propiedades DbSet para acceder a las entidades del modelo y configura las relaciones entre ellas.
    /// </summary>
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

        /// <summary>
        /// Constructor de la clase MediaManagerDbContext.
        /// Configura el contexto de base de datos utilizando la cadena de conexión "MediaManagerDb".
        /// </summary>
        public MediaManagerDbContext() : base("MediaManagerDb")
        { }

        /// <summary>
        /// Propiedad DbSet para acceder a la tabla de países en el contexto de base de datos.
        /// </summary>
        public DbSet<Country> Countries { get => iCountries; set => iCountries = value; }
        /// <summary>
        /// Propiedad DbSet para acceder a la tabla de géneros en el contexto de base de datos.
        /// </summary>
        public DbSet<Genre> Genres { get => iGenres; set => iGenres = value; }
        /// <summary>
        /// Propiedad DbSet para acceder a la tabla de medias en el contexto de base de datos.
        /// </summary>
        public DbSet<Media> Media { get => iMedia; set => iMedia = value; }
        /// <summary>
        /// Propiedad DbSet para acceder a la tabla de actores en el contexto de base de datos.
        /// </summary>
        public DbSet<Actor> Actors { get => iActors; set => iActors = value; }
        /// <summary>
        /// Propiedad DbSet para acceder a la tabla de directores en el contexto de base de datos.
        /// </summary>
        public DbSet<Director> Directors { get => iDirectors; set => iDirectors = value; }
        /// <summary>
        /// Propiedad DbSet para acceder a la tabla de escritores en el contexto de base de datos.
        /// </summary>
        public DbSet<Writer> Writers { get => iWriters; set => iWriters = value; }
        /// <summary>
        /// Propiedad DbSet para acceder a la tabla de usuarios en el contexto de base de datos.
        /// </summary>
        public DbSet<User> Users { get => iUsers; set => iUsers = value; }
        /// <summary>
        /// Propiedad DbSet para acceder a la tabla de reseñas en el contexto de base de datos.
        /// </summary>
        public DbSet<Review> Reviews { get => iReviews; set => iReviews = value; }
        /// <summary>
        /// Propiedad DbSet para acceder a la tabla de elementos de lista de seguimiento en el contexto de base de datos.
        /// </summary>
        public DbSet<WatchListItem> WatchListItems { get => iWatchListItems; set => iWatchListItems = value; }

        /// <summary>
        /// Método que configura las relaciones y propiedades de la entidad en el modelo de base de datos.
        /// </summary>
        /// <param name="modelBuilder">Constructor de modelos para configurar el modelo de base de datos.</param>
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
