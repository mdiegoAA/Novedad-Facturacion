namespace ModelContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AreasAprobacion")]
    public partial class AreasAprobacion
    {
        [Key]
        public int idArea { get; set; }

        public string AreaDescripcion { get; set; }

        public Guid idUsuarioAprobacion { get; set; }
    }
}
