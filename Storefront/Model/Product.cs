using System.ComponentModel.DataAnnotations;

namespace Storefront.Model
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        [Required]
        public double Price { get; set; }
        public double Discount { get; set; }
        public string ImageURL { get; set; }
    }
}
