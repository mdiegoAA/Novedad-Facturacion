namespace ModelContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConsecutivoPrueba")]
    public partial class ConsecutivoPrueba
    {
        [Key]
        [Column(Order = 0)]
        public Guid idFactura { get; set; }

        [Key]
        [Column(Order = 1)]
        public int consecutivo { get; set; }
    }
}
