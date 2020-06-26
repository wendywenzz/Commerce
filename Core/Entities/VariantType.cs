using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    [Table("VariantType")]
    public class VariantType : BaseEntity
    {
        public VariantType()
        {
        }

        [Column("VariantTypeId")]
        public int VariantTypeId { get; set; }

        [Column("Name")]
        [Required]
        public string Name { get; set; }

        [InverseProperty("VariantType")]
        public ICollection<VariantTypeMember> VariantTypeMember { get; set; }
    }
}