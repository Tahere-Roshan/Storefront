using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storefront.Model
{
    public class Reservations
    {
        public int ID { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int TourID { get; set; }
        public Tour Tour { get; set; }

    }
}
