using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS.Application.Entities
{
    public abstract class InsuranceProvider
    {
        public string Identifier { get; set; }
        public string Address { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
    }
}
