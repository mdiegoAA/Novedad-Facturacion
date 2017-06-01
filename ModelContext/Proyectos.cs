namespace ModelContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Proyectos
    {
        [Key]
        public Guid ProyectoId { get; set; }

        [StringLength(128)]
        public string NombreProyecto { get; set; }

        public int Año { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFinal { get; set; }

        public decimal BolsaHoras { get; set; }

        public Guid? AuditorId { get; set; }

        public Guid ClienteId { get; set; }

        public Guid DirectorId { get; set; }

        public Guid GerenteId { get; set; }

        public Guid? SupervisorId { get; set; }
    }
}
