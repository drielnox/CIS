﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Presentation.Models.Administration
{
    public class NewUserViewModel
    {
        public string StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Profile { get; set; }
    }
}
