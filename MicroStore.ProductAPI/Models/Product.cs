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

        [Required]
        [DataType("decimal(6,4)")]
        public double Price { get; set; }
    }
}
