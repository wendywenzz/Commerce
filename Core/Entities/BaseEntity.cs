using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class BaseEntity
    {
        [Column("DtmCrt")]
        public DateTimeOffset DtmCrt { get; set; } = DateTimeOffset.Now;
    }
}