using System;
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations; 
using System.Threading.Tasks ; 
using System.Linq ; 
namespace webapp.Models
{
    public class Cinema
    {
        [Key]
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        

        //relationship 
        public List<Movie>Movies { get; set; }

        
    }
}