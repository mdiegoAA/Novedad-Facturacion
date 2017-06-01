namespace ModelContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstadoAprobacionFactura")]
    public partial class EstadoAprobacionFactura
    {
        [Key]
        public int idEstado { get; set; }

        [StringLength(200)]
        public string DescripcionEstado { get; set; }
    }
}
