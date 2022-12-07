using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storefront.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
       List<Customer>? customers { get; set; }
    }
}
