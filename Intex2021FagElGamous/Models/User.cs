using System;
using System.Collections.Generic;

#nullable disable

namespace Intex2021FagElGamous.Models
{
    public partial class User
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string PassHash { get; set; }
        public string PassSalt { get; set; }
        public string PassIterations { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
    }
}
