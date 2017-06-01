namespace ModelContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext")
        {
        }


        public virtual DbSet<Proyectos> Proyectos { get; set; }

        public virtual DbSet<ControlFacturacion> ControlFacturacion { get; set; }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<AprobacionesFacturas> AprobacionesFacturas { get; set; }
        public virtual DbSet<Cargos> Cargos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<ClientePropuesta> ClientePropuesta { get; set; }

        public virtual DbSet<Servicios> Servicios { get; set; }

        public virtual DbSet<NovedadFactura> NovedadFactura { get; set; }

        public virtual DbSet<ConsecutivoPrueba> ConsecutivoPrueba { get; set; }
        public virtual DbSet<EstadosFactura> EstadosFactura { get; set; }
        public virtual DbSet<EstadosFactura_Factura> EstadosFactura_Factura { get; set; }

        public virtual DbSet<AreasAprobacion> AreasAprobacion { get; set; }
        public virtual DbSet<UsuarioAprobacion> UsuarioAprobacion { get; set; }

        public virtual DbSet<EstadoAprobacionFactura> EstadoAprobacionFactura { get; set; }

        public virtual DbSet<FacturaAprobacion> FacturaAprobacion { get; set; }

        public virtual DbSet<GruposTrabajo> GruposTrabajo { get; set; }


        public virtual DbSet<MensajeFactura> MensajeFactura { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cargos>()
                .HasMany(e => e.Usuarios)
                .WithRequired(e => e.Cargos)
                .WillCascadeOnDelete(false);


           
            modelBuilder.Entity<ClientePropuesta>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<ClientePropuesta>()
                .Property(e => e.Nit)
                .IsUnicode(false);

            modelBuilder.Entity<ClientePropuesta>()
                .Property(e => e.Dv)
                .IsUnicode(false);

            modelBuilder.Entity<ClientePropuesta>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<ClientePropuesta>()
                .Property(e => e.TipoContribuyente)
                .IsUnicode(false);

            modelBuilder.Entity<ClientePropuesta>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<ClientePropuesta>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<ClientePropuesta>()
                .Property(e => e.ContactoCliente)
                .IsUnicode(false);

            modelBuilder.Entity<ClientePropuesta>()
                .Property(e => e.Email)
                .IsUnicode(false);


            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.ConsecutivoControlTiempo)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.Sector)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.Antiguedad)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.numeroContrato)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.ValorAnualSinIva)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.MesesCuotasEjecucion)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.ManejoCuotaInicial)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.PorcentajeCuotaInicial)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.ValorCuotaInicial)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.ValorCoutasMensuales)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.ValorMensualSinIva)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.Gravado)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.ValorTotalContratoIncluidoIvaAnual)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.FacturacionMensual)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.FechaEntregaFacturacion)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.CondicionIniciarFacturacion)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.TextoFacturacionObservaciones)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.ventaCargo1)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.ProcentajeventaCargo1)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.ventaCargo2)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.ProcentajeventaCargo2)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.ventaCargo3)
                .IsUnicode(false);

            modelBuilder.Entity<NovedadFactura>()
                .Property(e => e.ProcentajeventaCargo3)
                .IsUnicode(false);


        }

        public virtual DbSet<estadoAprobacionArea> estadoAprobacionArea { get; set; }

    }
}
