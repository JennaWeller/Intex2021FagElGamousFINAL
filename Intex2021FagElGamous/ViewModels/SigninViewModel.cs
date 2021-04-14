using System;
using System.ComponentModel.DataAnnotations;

namespace Intex2021FagElGamous.Models
{
    public class SigninViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
