using System ; 
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations; 
using System.Threading.Tasks ; 
using System.Linq ; 
using webapp.Models ; 
using Microsoft.EntityFrameworkCore ; 
namespace webapp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am=> new {
                am.ActorId , 
                am.MovieId
            }) ; 

            modelBuilder.Entity<Actor_Movie>().HasOne(m=>m.Movie).WithMany(am=>am.Actors_Movies)
            .HasForeignKey(m=>m.MovieId) ; 
            base.OnModelCreating(modelBuilder) ; 
        }
    }
}