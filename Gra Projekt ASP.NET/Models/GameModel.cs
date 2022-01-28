using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Gra_Projekt_ASP.NET.Models
{
    public class GameModel
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Name { get; set; }    
        [DisplayName("Category")]
        
        public string Category { get; set; }

        
    }
}
