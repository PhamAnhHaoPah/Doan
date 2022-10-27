using System;
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations; 
using System.Threading.Tasks ; 
using System.Linq ; 
namespace webapp.Models
{
    public class Movie
    {
        [Key]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //relationship 
        public List<Actor_Movie> Actors_Movies { get; set; }
        //Cinema
        public int CinemaId {get;set ; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema {get ; set ; }


    }
}