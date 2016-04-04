using System;
using System.ComponentModel.DataAnnotations;

namespace CIS.Application.Entities
{
    public class Clinic : Person
    {
        public int Identifier { get; set; }
        public string InternalCode { get; set; }
        public string Specialty { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
