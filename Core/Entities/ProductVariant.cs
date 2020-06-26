using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    [Table("ProductVariant")]
    public class ProductVariant : BaseEntity
    {
        public ProductVariant()
        {
        }

        [Column("ProductVariantId")]
        public int ProductVariantId { get; set; }
        [Column("ShortName")]
        [Required]
        public int ProductId { get; set; }
        [Column("FirstVariantTypeMemberId")]
        [Required]
        public int FirstVariantTypeMemberId { get; set; }
        [Column("SecondVariantTypeMemberId")]
        public int? SecondVariantTypeMemberId { get; set; }



        [ForeignKey("ProductId")]
        [InverseProperty("ProductVariant")]
        public virtual Product Product { get; set; }

        [ForeignKey("FirstVariantTypeMemberId")]
        [InverseProperty("FirstVariantTypeMember")]
        public virtual VariantTypeMember FirstVariantTypeMember { get; set; }

        [ForeignKey("SecondVariantTypeMemberId")]
        [InverseProperty("SecondVariantTypeMember")]
        public virtual VariantTypeMember SecondVariantTypeMember { get; set; }


        [InverseProperty("ProductVariant")]
        public virtual ICollection<ProductDetail> ProductDetail { get; set; }
    }
}