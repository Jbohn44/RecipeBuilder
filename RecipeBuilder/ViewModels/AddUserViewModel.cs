using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeBuilder.ViewModels
{
    public class AddUserViewModel
    {
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email Address Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username Required")]
        [Range(8, 20)]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [MaxLength(25)]
        public string Password { get; set; }

        [Display(Name ="Confirm Password")]
        [Required(ErrorMessage ="Please Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
