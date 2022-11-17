using Microsoft.EntityFrameworkCore;
using Movie_tickets.Controllers;
using Movie_tickets.Models;

namespace Movie_tickets.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<Actor_movie>().HasOne(m=>m.Movie).WithMany(am=>am.Actors_movies).HasForeignKey(m=>m.MovieId);
            modelBuilder.Entity<Actor_movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_movies).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder); 
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_movie> Actors_movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }

        public static implicit operator AppDbContext(ActorsController v)
        {
            throw new NotImplementedException();
        }
    }
}
