using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    [Table("ProductDetail")]
    public class ProductDetail : BaseEntity
    {
        public ProductDetail()
        {
        }

        [Column("ProductDetailId")]
        public int ProductDetailId { get; set; }

        [Column("ProductId")]
        [Required]
        public int ProductId { get; set; }
        [Column("ProductVariantId")]
        [Required]
        public int ProductVariantId { get; set; }
        [Column("SKU")]
        [Required]
        public string SKU { get; set; }
        [Column("Price")]
        [Required]
        public decimal Price { get; set; }

        [ForeignKey("ProductId")]
        [InverseProperty("ProductDetail")]
        public Product Product { get; set; }

        [ForeignKey("ProductVariantId")]
        [InverseProperty("ProductDetail")]
        public ProductVariant ProductVariant { get; set; }
    }
}