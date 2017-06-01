namespace ModelContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsuarioAprobacion")]
    public partial class UsuarioAprobacion
    {
        [Key]
        [Column(Order = 0)]
        public Guid idUsuario { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idArea { get; set; }
    }
}
