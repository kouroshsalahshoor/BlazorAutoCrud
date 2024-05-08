using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
    }
}
