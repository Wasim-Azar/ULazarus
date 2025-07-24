using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ULazarusData.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "The Password must be at least 8 characters long.")]
       
        [RegularExpression(@"^(?=.*[0-9])(?=.*[a-zA-Z]).{8,}$",
            ErrorMessage = "The Password must contain at least one number and one letter, and be at least 8 characters long.")]
        public string Password { get; set; } = string.Empty;

        public bool RememberMe { get; set; }
    }
}