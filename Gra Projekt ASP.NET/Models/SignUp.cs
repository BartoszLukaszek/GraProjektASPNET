using System.ComponentModel.DataAnnotations;

namespace Gra_Projekt_ASP.NET.Models
{
    public class SignUp
    {
        [Key]
        
        
        public int ID { get; set; }
       
        [Display(Name ="First Name")]
        [Required(ErrorMessage = "You need to give your first name")]
        public string FirstName { get; set; }
        
        [Display(Name ="Last Name ")]
        [Required(ErrorMessage ="You need to give your last name")]
        public string LastName { get; set; }
       
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Email Address")]
        [Required(ErrorMessage ="You need to give your email address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage ="You must have a password")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength =8, ErrorMessage ="You need to provide a long enought password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Your password and confirm password do not match ")]
        public string ConfirmPassword { get; set; }
    }
}
