namespace ModelContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cargos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cargos()
        {
            Usuarios = new List<Usuarios>();
        }

        [Key]
        public Guid CargoId { get; set; }

        [StringLength(8)]
        public string Codigo { get; set; }

        [StringLength(128)]
        public string NombreCargo { get; set; }

        public decimal Tarifa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Usuarios> Usuarios { get; set; }
    }
}
