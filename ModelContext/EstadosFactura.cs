namespace ModelContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstadosFactura")]
    public partial class EstadosFactura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
     

        [Key]
        public Guid idEstado { get; set; }

        public int IdentificadorEstado { get; set; }

        [StringLength(100)]
        public string DescripcionEstado { get; set; }

    }
}
