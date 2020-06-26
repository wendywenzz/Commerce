using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    [Table("Product")]
    public class Product : BaseEntity
    {
        [Column("ProductId")]
        public int ProductId { get; set; }
        [Column("Name")]
        [Required]
        public string Name { get; set; }
        [Column("Description")]
        [Required]
        public string Description { get; set; }
        [Column("PictureUrl")]
        [Required]
        public string PictureUrl { get; set; }
        [Column("ProductCategoryId")]
        [Required]
        public int ProductCategoryId { get; set; }
        [Column("UnitOfMeasurementId")]
        [Required]
        public int UnitOfMeasurementId { get; set; }
        [Column("Weight")]
        [Required]
        public decimal Weight { get; set; }
        [Column("IsUseVariant")]
        [Required]
        public bool IsUseVariant { get; set; }

        [ForeignKey("ProductCategoryId")]
        [InverseProperty("Product")]
        public ProductCategory ProductCategory { get; set; }

        [ForeignKey("UnitOfMeasurementId")]
        [InverseProperty("Product")]
        public UnitOfMeasurement UnitOfMeasurement { get; set; }



        [InverseProperty("Product")]
        public virtual ICollection<ProductVariant> ProductVariant { get; set; }

        [InverseProperty("Product")]
        public virtual ICollection<ProductDetail> ProductDetail { get; set; }

    }
}