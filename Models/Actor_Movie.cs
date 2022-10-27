using System ; 
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations; 
using System.Threading.Tasks ; 
using System.Linq ; 
namespace webapp.Models
{
    public class Actor_Movie
    {
        public int MovieId {get;set;}
        public Movie Movie {get ; set ; }
        public int ActorId {get; set; } 
        public Actor Actor {get ; set ; } 

    }
}