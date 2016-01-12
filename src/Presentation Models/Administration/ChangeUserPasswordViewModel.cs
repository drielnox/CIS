using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Presentation.Models.Administration
{
    public class ChangeUserPasswordViewModel
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
