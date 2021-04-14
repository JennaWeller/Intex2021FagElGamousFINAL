using System;
namespace Intex2021FagElGamous.Models
{
    public class ResetPasswordViewModel
    {
        public string PreviousPassword { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordConfirmed { get; set; }
    }
}
