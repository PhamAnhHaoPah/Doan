using System.IO;
using System;
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations; 
using System.Threading.Tasks ; 
using System.Linq ; 
namespace webapp.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; } 
         public string MyProperty { get; set; }
         public string FullName { get; set; }
         public string Bio { get; set; }
        
        //Relationship 
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
  
}