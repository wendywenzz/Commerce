using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    [Table("ProductCategory")]
    public class ProductCategory : BaseEntity
    {
        public ProductCategory()
        {
        }

        [Column("ProductCategoryId")]
        public int ProductCategoryId { get; set; }
        [Column("Name")]
        [Required]
        public string Name { get; set; }

        [Column("ParentCategoryId")]
        public int? ParentCategoryId { get; set; }


        [ForeignKey("ParentCategoryId")]
        [InverseProperty("ChildCategory")]
        public ProductCategory ParentCategory { get; set; }


        [InverseProperty("ParentCategory")]
        public ICollection<ProductCategory> ChildCategory { get; set; }


        [InverseProperty("ProductCategory")]
        public ICollection<Product> Product { get; set; }
    }
}