
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ASPNetCoreAssign.Attributes;

namespace ASPNetCoreAssign.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a strong Password")]
        [Display(Name = "Password")]
        [StringLength(maximumLength: 15, MinimumLength = 6, ErrorMessage = "Length must be between 6 to 15")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter a Confirm Password")]
        [Compare("Password", ErrorMessage = "Confirm Password does not match")]
      
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter contact number")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Contact number is not a valid contact number")]
          
        public string Contact { get; set; }

        [Required(ErrorMessage = "Please enter Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Select City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Select Gender")]
        public string Gender { get; set; }

        [ValidateCheckBox(ErrorMessage = "Please accept terms and conditions")]
        public bool Terms { get; set; }

    }
}
