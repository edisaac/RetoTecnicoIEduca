using IEduca.Model;
using IEduca.Persistence.Config;
using Microsoft.EntityFrameworkCore;
using System;

namespace IEduca.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Album> Albumes { get; set; }
        public DbSet<Cancion> Canciones { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            new AlbumConfig(builder.Entity<Album>());
            new CancionConfig(builder.Entity<Cancion>());
        }
    }
}
