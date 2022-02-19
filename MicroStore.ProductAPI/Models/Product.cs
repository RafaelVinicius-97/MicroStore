using System.ComponentModel.DataAnnotations;

namespace MicroStore.ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        [StringLength(250)]
        [Required]
        public string Description { get; set; }

        [Range(1,1000)]
        [Required]
        public decimal Price { get; set; }
    }
}
