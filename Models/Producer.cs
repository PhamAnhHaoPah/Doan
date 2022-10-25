using System ; 
using System.Collections.Generic; 
using System.ComponentModel.DataAnnotations; 
using System.Threading.Tasks ; 
using System.Linq ; 
namespace webapp.Models
{
    public class Producer
    {
            
        [Key]
        public int ActorId { get; set; } 
         public string MyProperty { get; set; }
         public string FullName { get; set; }
         public string Bio { get; set; }

    }
}