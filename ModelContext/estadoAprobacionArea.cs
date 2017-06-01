namespace ModelContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estadoAprobacionArea")]
    public partial class estadoAprobacionArea
    {
        [Key]
        [Column(Order = 0)]
        public Guid IdFactura { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EstadoHorasIT { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EstadoHorasIFRS { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EstadosHorasImpuestos { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EstadoHorasLegal { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EstadoFiscal { get; set; }
    }
}
