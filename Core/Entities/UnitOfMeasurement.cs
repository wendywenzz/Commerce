using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    [Table("UnitOfMeasurement")]
    public class UnitOfMeasurement : BaseEntity
    {
        public UnitOfMeasurement()
        {
        }

        [Column("UnitOfMeasurementId")]
        public int UnitOfMeasurementId { get; set; }
        [Column("ShortName")]
        [Required]
        public string ShortName { get; set; }
        [Required]
        [Column("Name")]
        public string Name { get; set; }


        [InverseProperty("UnitOfMeasurement")]
        public ICollection<Product> Product { get; set; }
    }
}