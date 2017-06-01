namespace ModelContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clientes
    {
        [Key]
        public Guid ClienteId { get; set; }

        [StringLength(8)]
        public string Codigo { get; set; }

        [StringLength(16)]
        public string NIT { get; set; }

        [StringLength(128)]
        public string NombreCliente { get; set; }
    }
}
