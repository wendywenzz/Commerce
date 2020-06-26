using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    [Table("VariantTypeMember")]
    public class VariantTypeMember : BaseEntity
    {
        public VariantTypeMember()
        {
        }

        [Column("VariantTypeMemberId")]
        public int VariantTypeMemberId { get; set; }
        [Column("Name")]
        [Required]
        public string Name { get; set; }

        [Column("VariantTypeId")]
        [Required]
        public int VariantTypeId { get; set; }

        [ForeignKey("VariantTypeId")]
        [InverseProperty("VariantTypeMember")]
        public virtual VariantType VariantType { get; set; }


        [InverseProperty("FirstVariantTypeMember")]
        public virtual ICollection<ProductVariant> FirstVariantTypeMember { get; set; }
        [InverseProperty("SecondVariantTypeMember")]
        public virtual ICollection<ProductVariant> SecondVariantTypeMember { get; set; }
    }
}