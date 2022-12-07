using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storefront.Model
{
    public class Tour
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string? Date { get; set; }
        public int? Price { get; set; }

        [NotMapped]
        public int? CURD { get; set; }
        public List<Reservations>? Reservations { get; set; }



    }
}
