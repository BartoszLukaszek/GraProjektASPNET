﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Gra_Projekt_ASP.NET.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Name { get; set; }    
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display Order must be between 1 and 100 only!!")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDataTime { get; set; } = DateTime.Now;
    }
}
