namespace ModelContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GruposTrabajo")]
    public partial class GruposTrabajo
    {
        [Key]
        [Column(Order = 0)]
        public Guid ProyectoId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid UsuarioId { get; set; }
    }
}
