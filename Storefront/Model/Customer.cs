using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storefront.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public int? NationalID { get; set; }
        public string Name { get; set; }
        public int? Phone { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }
        public int EmployeeId { get; set; } 
        public Employee? Employee { get; set; }
        public List<Reservations>? Reservations { get; set; }


    }
}
