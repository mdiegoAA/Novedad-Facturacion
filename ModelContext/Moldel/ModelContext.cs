namespace ModelContext.Moldel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext1")
        {
        }

        public virtual DbSet<AprobacionesFacturas> AprobacionesFacturas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
