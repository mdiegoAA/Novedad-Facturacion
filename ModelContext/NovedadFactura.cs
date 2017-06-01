namespace ModelContext
{
    
    using System.Web;
    using System.IO;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using Helpers;
    using Entidades;
    using System.Data.SqlClient;
    using Newtonsoft.Json;

    [Table("NovedadFactura")]
    public partial class NovedadFactura
    {



        [Key]
        [Column(Order = 0)]
        public Guid FacturaID { get; set; }
    //    public Guid FacturaID { get; set; }
        [Key]
        [Column(Order = 1)]
        public DateTime FechaDiligenciamiento { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string ConsecutivoControlTiempo { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid IdCliente { get; set; }

        [Key]
        [Column(Order = 4)]
        public Guid TipoServicio { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string Sector { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string Antiguedad { get; set; }

        [StringLength(100)]
        public string numeroContrato { get; set; }

        [StringLength(100)]
        public string ValorAnualSinIva { get; set; }

        [StringLength(100)]
        public string MesesCuotasEjecucion { get; set; }

        [StringLength(100)]
        public string ManejoCuotaInicial { get; set; }

        [StringLength(100)]
        public string PorcentajeCuotaInicial { get; set; }

        [StringLength(100)]
        public string ValorCuotaInicial { get; set; }

        [StringLength(100)]
        public string ValorCoutasMensuales { get; set; }

        [StringLength(100)]
        public string ValorMensualSinIva { get; set; }

        [StringLength(100)]
        public string Gravado { get; set; }

        [StringLength(100)]
        public string ValorTotalContratoIncluidoIvaAnual { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime FechaInicioContrato { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime FechaFinalizacionContrato { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime FechaInicioFacturacion { get; set; }

        [StringLength(100)]
        public string FacturacionMensual { get; set; }

        [StringLength(100)]
        public string FechaEntregaFacturacion { get; set; }

        [StringLength(100)]
        public string CondicionIniciarFacturacion { get; set; }

        public string TextoFacturacionObservaciones { get; set; }

       

        [Key]
        [Column(Order = 16)]
        public Guid IdGerenteCargo { get; set; }

        [Key]
        [Column(Order = 17)]
        public Guid IdDirectorCargo { get; set; }

        [StringLength(100)]
        public string ventaCargo1 { get; set; }

        [StringLength(10)]
        public string ProcentajeventaCargo1 { get; set; }

        [StringLength(100)]
        public string ventaCargo2 { get; set; }

        [StringLength(10)]
        public string ProcentajeventaCargo2 { get; set; }

        [StringLength(100)]
        public string ventaCargo3 { get; set; }

        [StringLength(10)]
        public string ProcentajeventaCargo3 { get; set; }

        public Guid UsuarioCreado { get; set; }

       

        [StringLength(200)]
        public string Asistente_auditoría { get; set; }

        [StringLength(200)]
        public string Auditor_Junior { get; set; }

        [StringLength(200)]
        public string Auditor_Semisenior { get; set; }

        [StringLength(200)]
        public string Auditor_Senior { get; set; }

        [StringLength(200)]
        public string Supervisor_Junior { get; set; }

        [StringLength(200)]
        public string Supervisor_Semisenior { get; set; }

        [StringLength(200)]
        public string Supervisor_Senior { get; set; }

        [StringLength(200)]
        public string Gerente_Junior { get; set; }

        [StringLength(200)]
        public string Gerente_Semisenior { get; set; }

        [StringLength(200)]
        public string Gerente_Senior { get; set; }

        [StringLength(200)]
        public string Director_Junior { get; set; }

        [StringLength(200)]
        public string Director_Semisenior { get; set; }

        [StringLength(200)]
        public string Director_Senior { get; set; }

        [StringLength(200)]
        public string Total_auditoría { get; set; }

        [StringLength(200)]
        public string Auditor_TI { get; set; }

        [StringLength(200)]
        public string Supervisor_TI { get; set; }

        [StringLength(200)]
        public string Gerente_TI { get; set; }

        [StringLength(200)]
        public string Auditor_impuestos { get; set; }

        [StringLength(200)]
        public string Gerente_impuestos { get; set; }

        [StringLength(200)]
        public string Asesor_Jurídico { get; set; }

        [StringLength(200)]
        public string Gerente_Jurídico { get; set; }

        [StringLength(200)]
        public string Total_especialistas { get; set; }

        [StringLength(200)]
        public string TOTALTIEMPO { get; set; }


        [StringLength(100)]
        public string TotalHorasAuditoriaTI { get; set; }

        [StringLength(100)]
        public string TotalHorasAuditoriaImpuesto { get; set; }

        [StringLength(100)]
        public string TotalHorasAuditoriaJuridica { get; set; }

        [StringLength(100)]
        public string RsultTotalAprox { get; set; }

        [StringLength(100)]
        public string valueEx { get; set; }

        [StringLength(100)]
        public string GJuridicoAprox { get; set; }

        [StringLength(100)]
        public string AsesorJuridicoProx { get; set; }

        [StringLength(100)]
        public string AuditorImpuestoAprox { get; set; }

        [StringLength(100)]
        public string GerenteTIAprox { get; set; }

        [StringLength(100)]
        public string supervisorTIAprox { get; set; }

        [StringLength(100)]
        public string AuditorTIAprox { get; set; }

        [StringLength(100)]
        public string vaueAuditoriaAprox { get; set; }

        [StringLength(100)]
        public string DSeniorAprox { get; set; }

        [StringLength(100)]
        public string DSemiAprox { get; set; }

        [StringLength(100)]
        public string DJuniorAprox { get; set; }

        [StringLength(100)]
        public string GSeniorAprox { get; set; }

        [StringLength(100)]
        public string GSemiAprox { get; set; }

        [StringLength(100)]
        public string GJuniorAprox { get; set; }

        [StringLength(100)]
        public string SseniorAprox { get; set; }

        [StringLength(100)]
        public string SsemiseniorAprox { get; set; }

        [StringLength(100)]
        public string SjuniorAprox { get; set; }

        [StringLength(100)]
        public string ASeniorAprox { get; set; }

        [StringLength(100)]
        public string ASemiseniorAprox { get; set; }

        [StringLength(100)]
        public string AjuniorAprox { get; set; }

        [StringLength(100)]
        public string AauditoriaProx { get; set; }

        [StringLength(100)]
        public string horasAnoProx { get; set; }

        [StringLength(100)]
        public string horasAno { get; set; }



        [StringLength(100)]
        public string OutGerenteval { get; set; }

        [StringLength(100)]
        public string OutGerentevalAprox { get; set; }

        [StringLength(100)]
        public string outSupervisorVal { get; set; }

        [StringLength(100)]
        public string outSupervisorValProx { get; set; }

        [StringLength(100)]
        public string outcordinadorVal { get; set; }

        [StringLength(100)]
        public string outcordinadorValProx { get; set; }

        [StringLength(100)]
        public string outAnalistaVal { get; set; }

        [StringLength(100)]
        public string outAnalistaValProx { get; set; }

        [StringLength(100)]
        public string outAuxiliarVal { get; set; }

        [StringLength(100)]
        public string outAuxiliarValProx { get; set; }

        [StringLength(100)]
        public string RsultTotalesOut { get; set; }

        [StringLength(100)]
        public string RsultTotalAproxes { get; set; }

        [StringLength(100)]
        public string Totaloutsourcing { get; set; }

        [StringLength(10)]
        public string GImpuestosAprox { get; set; }

        [StringLength(100)]


        public CorreoElectronico correoElectronico = new CorreoElectronico();
        public string TipoContribuyente { get; set; }


        //  public string Mensaje { get; set; }


        //    public virtual ClientePropuesta clientePropuesta { get; set; }

        public void guardarNovedadFactura(string Mensaje)
        {
            var rm = new ResponseModel();

            try
            {


                using (var ctx = new ModelContext()) {

                    string usuario = SessionHelper.GetUser();

                    Guid usarioAutenticado = Guid.Parse(usuario);
                    this.UsuarioCreado = usarioAutenticado;
                    ctx.Entry(this).State = System.Data.Entity.EntityState.Added;
                    ctx.SaveChanges();

             guardarEstadoFactura(this.FacturaID );

                 voidGuardarEstado(1,this.FacturaID);
                 consecutivo(this.FacturaID);
                    string MnesajeSistema = "Factura creada por";
                 guardarMensaje(this.FacturaID ,Mensaje , MnesajeSistema);

                    //if (this.HorasSistemas > 0) {


                    //    aprobacionHoraIT(this.FacturaID , this.HorasSistemas , 1);



                    //}


                    //if (this.HorasImpuestos > 0) {

                    //    aprobacionHoraIT(this.FacturaID, this.HorasImpuestos, 2);



                    //}


                };


            }
            catch (Exception)
            {

                throw;
            }

        }

        public void EditarNovedadFacturasM(string Mensaje)
        {
            var rm = new ResponseModel();

            try
            {


                using (var ctx = new ModelContext())
                {

                   

                    ctx.Database.ExecuteSqlCommand(
                       "update NovedadFactura set TipoContribuyente=@TipoContribuyente, horasAnoProx=@horasAnoProx , horasAno=@horasAno , ProcentajeventaCargo3=@ProcentajeventaCargo3 , ventaCargo3=@ventaCargo3 , ProcentajeventaCargo2 =@ProcentajeventaCargo2 , ventaCargo2=@ventaCargo2 , ProcentajeventaCargo1 =@ProcentajeventaCargo1 , ventaCargo1 =@ventaCargo1 , TotalHorasAuditoriaImpuesto = @TotalHorasAuditoriaImpuesto , TotalHorasAuditoriaTI =@TotalHorasAuditoriaTI , TotalHorasAuditoriaJuridica=@TotalHorasAuditoriaJuridica , RsultTotalAprox=@RsultTotalAprox , TOTALTIEMPO=@TOTALTIEMPO , valueEx=@valueEx , Total_especialistas=@Total_especialistas , GJuridicoAprox=@GJuridicoAprox , Gerente_Jurídico=@Gerente_Jurídico , AsesorJuridicoProx=@AsesorJuridicoProx , Asesor_Jurídico=@Asesor_Jurídico , GImpuestosAprox =@GImpuestosAprox , Gerente_impuestos=@Gerente_impuestos , AuditorImpuestoAprox=@AuditorImpuestoAprox , Auditor_impuestos=@Auditor_impuestos , GerenteTIAprox=@GerenteTIAprox , Gerente_TI=@Gerente_TI, supervisorTIAprox=@supervisorTIAprox, Supervisor_TI=@Supervisor_TI , AuditorTIAprox=@AuditorTIAprox, Auditor_TI=@Auditor_TI, Total_auditoría=@Total_auditoría, vaueAuditoriaAprox=@vaueAuditoriaAprox , Director_Senior=@Director_Senior, DSemiAprox=@DSemiAprox , Director_Semisenior=@Director_Semisenior , DSeniorAprox=@DSeniorAprox , DJuniorAprox=@DJuniorAprox , Director_Junior=@Director_Junior , GSeniorAprox=@GSeniorAprox , Gerente_Senior=@Gerente_Senior , GSemiAprox=@GSemiAprox, Gerente_Semisenior=@Gerente_Semisenior , GJuniorAprox=@GJuniorAprox , Gerente_Junior=@Gerente_Junior, SseniorAprox=@SseniorAprox , Supervisor_Senior=@Supervisor_Senior , SsemiseniorAprox=@SsemiseniorAprox , Supervisor_Semisenior=@Supervisor_Semisenior , SjuniorAprox=@SjuniorAprox , Supervisor_Junior=@Supervisor_Junior , ASeniorAprox=@ASeniorAprox , Auditor_Senior=@Auditor_Senior, ASemiseniorAprox=@ASemiseniorAprox , Auditor_Semisenior=@Auditor_Semisenior , AjuniorAprox=@AjuniorAprox , Auditor_Junior=@Auditor_Junior , AauditoriaProx=@AauditoriaProx , Asistente_auditoría=@Asistente_auditoría ,  IdDirectorCargo=@IdDirectorCargo , Totaloutsourcing=@Totaloutsourcing , RsultTotalAproxes=@RsultTotalAproxes , RsultTotalesOut=@RsultTotalesOut, outAuxiliarValProx=@outAuxiliarValProx , outAuxiliarVal=@outAuxiliarVal , outAnalistaValProx=@outAnalistaValProx , outAnalistaVal=@outAnalistaVal , outcordinadorValProx=@outcordinadorValProx , outcordinadorVal=@outcordinadorVal , outSupervisorValProx =@outSupervisorValProx , outSupervisorVal=@outSupervisorVal , OutGerentevalAprox =@OutGerentevalAprox , OutGerenteval = @OutGerenteval , TextoFacturacionObservaciones=@TextoFacturacionObservaciones , CondicionIniciarFacturacion=@CondicionIniciarFacturacion, FacturacionMensual=@FacturacionMensual , FechaInicioFacturacion=@FechaInicioFacturacion , FechaFinalizacionContrato=@FechaFinalizacionContrato , FechaInicioContrato=@FechaInicioContrato , FechaEntregaFacturacion=@FechaEntregaFacturacion , ValorMensualSinIva =@ValorMensualSinIva , ValorTotalContratoIncluidoIvaAnual =@ValorTotalContratoIncluidoIvaAnual , Gravado=@Gravado , ValorCoutasMensuales=@ValorCoutasMensuales , ValorCuotaInicial=@ValorCuotaInicial , PorcentajeCuotaInicial=@PorcentajeCuotaInicial, ManejoCuotaInicial=@ManejoCuotaInicial ,  MesesCuotasEjecucion =@MesesCuotasEjecucion , IdGerenteCargo = @IdGerenteCargo,IdCliente =@IdCliente,ValorAnualSinIva =@ValorAnualSinIva , numeroContrato=@numeroContrato , TipoServicio =@TipoServicio , Antiguedad =@Antiguedad , Sector =@Sector  where FacturaID = @FacturaIDno",


                        // new SqlParameter("MesesCuotasEjecucion", this.MesesCuotasEjecucion),


                        new SqlParameter("TipoContribuyente", this.TipoContribuyente),
                         new SqlParameter("ventaCargo1", this.ventaCargo1),
                         new SqlParameter("ProcentajeventaCargo1", this.ProcentajeventaCargo1),

                        new SqlParameter("ventaCargo2", this.ventaCargo2),
                        new SqlParameter("ProcentajeventaCargo2", this.ProcentajeventaCargo2),

                           new SqlParameter("ventaCargo3", this.ventaCargo3),
                          new SqlParameter("ProcentajeventaCargo3", this.ProcentajeventaCargo3),



                        new SqlParameter("ManejoCuotaInicial", this.ManejoCuotaInicial),
                        new SqlParameter("ValorAnualSinIva", this.ValorAnualSinIva),
                        new SqlParameter("numeroContrato", this.numeroContrato),
                        new SqlParameter("Antiguedad", this.Antiguedad),
                        new SqlParameter("Sector", this.Sector),
                        new SqlParameter("IdCliente", this.IdCliente),
                        new SqlParameter("TipoServicio", this.TipoServicio),
                        // new SqlParameter("IdGerenteCargo", this.IdGerenteCargo),
                        new SqlParameter("FacturaIDno", this.FacturaID),
                        //  new SqlParameter("ValorAnualSinIva", this.ValorAnualSinIva),
                        new SqlParameter("MesesCuotasEjecucion", this.MesesCuotasEjecucion),
                        //   new SqlParameter("ManejoCuotaInicial", this.ManejoCuotaInicial),
                        new SqlParameter("PorcentajeCuotaInicial", this.PorcentajeCuotaInicial),
                        new SqlParameter("ValorCuotaInicial", this.ValorCuotaInicial),
                        new SqlParameter("ValorCoutasMensuales", this.ValorCoutasMensuales),
                        new SqlParameter("ValorMensualSinIva", this.ValorMensualSinIva),
                        new SqlParameter("Gravado", this.Gravado),
                        new SqlParameter("FechaEntregaFacturacion", this.FechaEntregaFacturacion),
                        new SqlParameter("FacturacionMensual", this.FacturacionMensual),
                        new SqlParameter("FechaInicioContrato", this.FechaInicioContrato),
                        new SqlParameter("FechaFinalizacionContrato", this.FechaFinalizacionContrato),
                        new SqlParameter("FechaInicioFacturacion", this.FechaInicioFacturacion),
                        new SqlParameter("CondicionIniciarFacturacion", this.CondicionIniciarFacturacion),
                        new SqlParameter("TextoFacturacionObservaciones", this.TextoFacturacionObservaciones),
                        new SqlParameter("ValorTotalContratoIncluidoIvaAnual", this.ValorTotalContratoIncluidoIvaAnual),
                        new SqlParameter("OutGerenteval", this.OutGerenteval),
                        new SqlParameter("OutGerentevalAprox", this.OutGerentevalAprox),
                        new SqlParameter("outSupervisorVal", this.outSupervisorVal),
                        new SqlParameter("outSupervisorValProx", this.outSupervisorValProx),
                        new SqlParameter("outcordinadorVal", this.outcordinadorVal),
                        new SqlParameter("outcordinadorValProx", this.outcordinadorValProx),
                        new SqlParameter("outAnalistaVal", this.outAnalistaVal),
                        new SqlParameter("outAnalistaValProx", this.outAnalistaValProx),
                        new SqlParameter("outAuxiliarVal", this.outAuxiliarVal),
                        new SqlParameter("outAuxiliarValProx", this.outAuxiliarValProx),
                        new SqlParameter("RsultTotalesOut", this.RsultTotalesOut),
                        new SqlParameter("RsultTotalAproxes", this.RsultTotalAproxes),
                        new SqlParameter("Totaloutsourcing", this.Totaloutsourcing),
                        new SqlParameter("IdGerenteCargo", this.IdGerenteCargo),
                        new SqlParameter("IdDirectorCargo", this.IdDirectorCargo),
                        new SqlParameter("Asistente_auditoría", this.Asistente_auditoría),
                        new SqlParameter("AauditoriaProx", this.AauditoriaProx),
                        new SqlParameter("Auditor_Junior", this.Auditor_Junior),
                        new SqlParameter("AjuniorAprox", this.AjuniorAprox),
                        new SqlParameter("Auditor_Semisenior", this.Auditor_Semisenior),
                        new SqlParameter("ASemiseniorAprox", this.ASemiseniorAprox),
                        new SqlParameter("Auditor_Senior", this.Auditor_Senior),
                        new SqlParameter("ASeniorAprox", this.ASeniorAprox),
                        new SqlParameter("Supervisor_Junior", this.Supervisor_Junior),
                        new SqlParameter("SjuniorAprox", this.SjuniorAprox),
                        new SqlParameter("Supervisor_Semisenior", this.Supervisor_Semisenior),
                        new SqlParameter("SsemiseniorAprox", this.SsemiseniorAprox),
                        new SqlParameter("Supervisor_Senior", this.Supervisor_Senior),
                        new SqlParameter("SseniorAprox", this.SseniorAprox),
                        new SqlParameter("Gerente_Junior", this.Gerente_Junior),
                        new SqlParameter("GJuniorAprox", this.GJuniorAprox),
                        new SqlParameter("Gerente_Semisenior", this.Gerente_Semisenior),
                        new SqlParameter("GSemiAprox", this.GSemiAprox),
                        new SqlParameter("Gerente_Senior", this.Gerente_Senior),
                        new SqlParameter("GSeniorAprox", this.GSeniorAprox),
                        new SqlParameter("Director_Junior", this.Director_Junior),
                        new SqlParameter("DJuniorAprox", this.DJuniorAprox),
                        new SqlParameter("Director_Semisenior", this.Director_Semisenior),
                        new SqlParameter("DSemiAprox", this.DSemiAprox),
                        new SqlParameter("Director_Senior", this.Director_Senior),
                        new SqlParameter("DSeniorAprox", this.DSeniorAprox),
                        new SqlParameter("Total_auditoría", this.Total_auditoría),
                        new SqlParameter("vaueAuditoriaAprox", this.vaueAuditoriaAprox),
                        new SqlParameter("Auditor_TI", this.Auditor_TI),
                        new SqlParameter("AuditorTIAprox", this.AuditorTIAprox),
                        new SqlParameter("Supervisor_TI", this.Supervisor_TI),
                        new SqlParameter("supervisorTIAprox", this.supervisorTIAprox),
                        new SqlParameter("Gerente_TI", this.Gerente_TI),
                        new SqlParameter("GerenteTIAprox", this.GerenteTIAprox),
                        new SqlParameter("Auditor_impuestos", this.Auditor_impuestos),
                        new SqlParameter("AuditorImpuestoAprox", this.AuditorImpuestoAprox),
                        new SqlParameter("Gerente_impuestos", this.Gerente_impuestos),
                        new SqlParameter("GImpuestosAprox", this.GImpuestosAprox),
                        new SqlParameter("Asesor_Jurídico", this.Asesor_Jurídico),
                        new SqlParameter("AsesorJuridicoProx", this.AsesorJuridicoProx),
                        new SqlParameter("Gerente_Jurídico", this.Gerente_Jurídico),
                        new SqlParameter("GJuridicoAprox", this.GJuridicoAprox),
                        new SqlParameter("Total_especialistas", this.Total_especialistas),
                        new SqlParameter("valueEx", this.valueEx),
                        new SqlParameter("TotalHorasAuditoriaJuridica", this.TotalHorasAuditoriaJuridica),

                        new SqlParameter("TOTALTIEMPO", this.TOTALTIEMPO),
                        new SqlParameter("RsultTotalAprox", this.RsultTotalAprox),
                        new SqlParameter("TotalHorasAuditoriaTI", this.TotalHorasAuditoriaTI),
                        new SqlParameter("TotalHorasAuditoriaImpuesto", this.TotalHorasAuditoriaImpuesto),
                            new SqlParameter("horasAno", this.horasAno),
                        new SqlParameter("horasAnoProx", this.horasAnoProx)







                       );


                    ctx.SaveChanges();

                    guardarMensaje(this.FacturaID, Mensaje, "Factura Editada");
               


                };


            }
            catch (Exception)
            {

                throw;
            }

        }


        public void guardarEstadoFactura(Guid facturaId)
        {

            AprobacionesFacturas estadoAprobacion = new AprobacionesFacturas();
            estadoAprobacion.FacturaID = facturaId;
            estadoAprobacion.Director = 1;
            estadoAprobacion.GerenciaGeneral = 1;
            estadoAprobacion.AsistenteGerenciaGeneral = 1;
            estadoAprobacion.Contabilidad = 1;


            try
            {


                using (var ctx = new ModelContext())
                {

                    ctx.Entry(estadoAprobacion).State = System.Data.Entity.EntityState.Added;
                    ctx.SaveChanges();



                }
            }
            catch (Exception)
            {

                throw;
            }

       


        }

       



        public List<FacturacionUsuario> obtenerListadoNovedadFactura() {


            var listaNovedadFactura = new List<FacturacionUsuario>();

            string usuario = SessionHelper.GetUser();

            Guid usarioAutenticado = Guid.Parse(usuario);

            using ( var ctx = new ModelContext()){
                try
                {



                    var Rsulat = (from novFactra in ctx.NovedadFactura
                                  from Usu in ctx.Usuarios
                                  from Serv in ctx.Servicios
                                  from estadoFactura in ctx.EstadosFactura_Factura
                                  from apro in ctx.AprobacionesFacturas
                                  from clienet in ctx.ClientePropuesta
                                  where Usu.UsuarioId == novFactra.IdGerenteCargo
                                  where Serv.ServicioId == novFactra.TipoServicio
                                  where estadoFactura.idFactura == novFactra.FacturaID
                                  where novFactra.UsuarioCreado == usarioAutenticado
                                  where apro.FacturaID == novFactra.FacturaID
                                  where clienet.ClienteID == novFactra.IdCliente
                                  where estadoFactura.IdentificadorEstado != 3

                                  select new FacturacionUsuario() {


                                      estadoDirector = apro.Director,
                                      estadoGerenciaGeneral = apro.GerenciaGeneral,
                                      estadeAsistenteGerencia = apro.AsistenteGerenciaGeneral,
                                      HorasTI = novFactra.TotalHorasAuditoriaTI,
                                      FacturaId = novFactra.FacturaID,
                                      FechaDiligenciamiento = novFactra.FechaDiligenciamiento,
                                      HorasAuditoria = novFactra.Total_auditoría,
                                      HorasImpuestos = novFactra.TotalHorasAuditoriaImpuesto,
                                      HorasLegales = novFactra.TotalHorasAuditoriaJuridica,
                                      TotalHoras = novFactra.TOTALTIEMPO,
                                      HorasOutsorcing = novFactra.Totaloutsourcing,
                                      nombre = Usu.Nombre,
                                      Servicio = Serv.NombreServicio,
                                      Estado = estadoFactura.IdentificadorEstado.ToString(),
                                      nombreCliente = clienet.RazonSocial
                                      
                                  }).OrderBy(x => x.FechaDiligenciamiento).ToList();

                    listaNovedadFactura = Rsulat;

                    return listaNovedadFactura;
                }
                catch (Exception e)
                {

                    throw;
                }

               

            }

        }



        public List<FacturacionUsuario> obtenerListadoNovedadFacturaXGerente()
        {

            var listaNovedadFactura = new List<FacturacionUsuario>();

            string usuario = SessionHelper.GetUser();

            Guid usarioAutenticado = Guid.Parse(usuario);

            using (var ctx = new ModelContext())
            {
                try
                {



                    var Rsulat = (from novFactra in ctx.NovedadFactura
                                  from Usu in ctx.Usuarios
                                  from Serv in ctx.Servicios
                                  from Apro in ctx.AprobacionesFacturas
                                  from cli in ctx.ClientePropuesta
                                  from estadoFactura in ctx.EstadosFactura_Factura
                                  where Usu.UsuarioId == novFactra.IdGerenteCargo
                                  where Serv.ServicioId == novFactra.TipoServicio
                                  where estadoFactura.idFactura == novFactra.FacturaID
                                  where novFactra.IdGerenteCargo == usarioAutenticado
                                  where novFactra.FacturaID == Apro.FacturaID
                                  where estadoFactura.IdentificadorEstado == 2
                                  where cli.ClienteID == novFactra.IdCliente

                                  select new FacturacionUsuario()
                                  {
                                    estadoContabilidadl = Apro.Contabilidad,
                                      estadoGerenciaGeneral = Apro.GerenciaGeneral,
                                      estadeAsistenteGerencia = Apro.AsistenteGerenciaGeneral,
                                      nombreCliente = cli.RazonSocial,
                                      estadoDirector = Apro.Director,
                                      HorasTI = novFactra.TotalHorasAuditoriaTI,
                                      FacturaId = novFactra.FacturaID,
                                      FechaDiligenciamiento = novFactra.FechaDiligenciamiento,
                                      HorasAuditoria = novFactra.Total_auditoría,
                                      HorasImpuestos = novFactra.TotalHorasAuditoriaImpuesto,
                                      HorasLegales = novFactra.TotalHorasAuditoriaJuridica,
                                      TotalHoras = novFactra.TOTALTIEMPO,
                                      HorasOutsorcing = novFactra.Totaloutsourcing,
                                      nombre = Usu.Nombre,
                                      Servicio = Serv.NombreServicio,

                                      Estado = estadoFactura.IdentificadorEstado.ToString()



                                  }).OrderBy(x => x.FechaDiligenciamiento).ToList();

                    listaNovedadFactura = Rsulat;

                    return listaNovedadFactura;
                }
                catch (Exception e)
                {

                    throw;
                }



            }



        }


        public List<FacturacionUsuario> obtenerListadoNovedadFacturaAreaEspecializada()
        {

            var listaNovedadFactura = new List<FacturacionUsuario>();

            string usuario = SessionHelper.GetUser();

            Guid usarioAutenticado = Guid.Parse(usuario);

            using (var ctx = new ModelContext())
            {
                try
                {



                    var Rsulat = (from novFactra in ctx.NovedadFactura
                                  from Usu in ctx.Usuarios
                                  from Serv in ctx.Servicios
                                  from Apro in ctx.AprobacionesFacturas
                                  from cli in ctx.ClientePropuesta
                                  from estadoFactura in ctx.EstadosFactura_Factura
                                  where Usu.UsuarioId == novFactra.IdGerenteCargo
                                  where Serv.ServicioId == novFactra.TipoServicio
                                  where estadoFactura.idFactura == novFactra.FacturaID
                                 // where novFactra.IdGerenteCargo == usarioAutenticado
                                  where novFactra.FacturaID == Apro.FacturaID
                                  where estadoFactura.IdentificadorEstado == 2
                                  where  Apro.Director == 2
                                  where Apro.GerenciaGeneral == 2
                                  where Apro.AsistenteGerenciaGeneral == 2                             
                                  where ((usarioAutenticado.ToString() == "E43B0C6A-2340-4E24-A450-5BB5179AE749")|| (usarioAutenticado.ToString() == "5D1F7469-F857-47F2-8DFD-0350AEAE0C8A") || (usarioAutenticado.ToString() == "85315D7B-CFFA-40AB-8AB4-678409D0F19B"))
                                  where cli.ClienteID == novFactra.IdCliente

                                  select new FacturacionUsuario()
                                  {

                                      estadoGerenciaGeneral = Apro.GerenciaGeneral,
                                      estadeAsistenteGerencia = Apro.AsistenteGerenciaGeneral,
                                      nombreCliente = cli.RazonSocial,
                                      estadoDirector = Apro.Director,
                                      HorasTI = novFactra.TotalHorasAuditoriaTI,
                                      FacturaId = novFactra.FacturaID,
                                      FechaDiligenciamiento = novFactra.FechaDiligenciamiento,
                                      HorasAuditoria = novFactra.Total_auditoría,
                                      HorasImpuestos = novFactra.TotalHorasAuditoriaImpuesto,
                                      HorasLegales = novFactra.TotalHorasAuditoriaJuridica,
                                      TotalHoras = novFactra.TOTALTIEMPO,
                                      HorasOutsorcing = novFactra.Totaloutsourcing,
                                      nombre = Usu.Nombre,
                                      Servicio = Serv.NombreServicio,
                                      Estado = estadoFactura.IdentificadorEstado.ToString()



                                  }).OrderBy(x => x.FechaDiligenciamiento).ToList();

                    listaNovedadFactura = Rsulat;

                    return listaNovedadFactura;
                }
                catch (Exception e)
                {

                    throw;
                }



            }



        }

        public List<FacturacionUsuario> obtenerListadoNovedadFacturaXDirector() { 
      


            var listaNovedadFactura = new List<FacturacionUsuario>();

            string usuario = SessionHelper.GetUser();

            Guid usarioAutenticado = Guid.Parse(usuario);

            using (var ctx = new ModelContext())
            {
                try
                {



                    var Rsulat = (from novFactra in ctx.NovedadFactura
                                  from Usu in ctx.Usuarios
                                  from Serv in ctx.Servicios
                                  from Apro in ctx.AprobacionesFacturas
                                  from cli in ctx.ClientePropuesta
                                  from estadoFactura in ctx.EstadosFactura_Factura
                                  where Usu.UsuarioId == novFactra.IdGerenteCargo
                                  where Serv.ServicioId == novFactra.TipoServicio
                                  where estadoFactura.idFactura == novFactra.FacturaID
                                  where novFactra.IdDirectorCargo == usarioAutenticado
                                  where novFactra.FacturaID == Apro.FacturaID
                                  where estadoFactura.IdentificadorEstado == 2
                                  where Apro.Contabilidad == 2
                                  where cli.ClienteID == novFactra.IdCliente

                                  select new FacturacionUsuario()
                                  {
                                      nombreCliente = cli.RazonSocial,
                                      estadoDirector = Apro.Director,
                                      HorasTI = novFactra.TotalHorasAuditoriaTI,
                                      FacturaId = novFactra.FacturaID,
                                      FechaDiligenciamiento = novFactra.FechaDiligenciamiento,
                                      HorasAuditoria = novFactra.Total_auditoría,
                                      HorasImpuestos = novFactra.TotalHorasAuditoriaImpuesto,
                                      HorasLegales = novFactra.TotalHorasAuditoriaJuridica,
                                      TotalHoras = novFactra.TOTALTIEMPO,
                                      HorasOutsorcing = novFactra.Totaloutsourcing,
                                      nombre = Usu.Nombre,
                                      Servicio = Serv.NombreServicio,
                                      Estado = estadoFactura.IdentificadorEstado.ToString()
                                      


                                  }).OrderBy(x => x.FechaDiligenciamiento).ToList();

                    listaNovedadFactura = Rsulat;

                    return listaNovedadFactura;
                }
                catch (Exception e)
                {

                    throw;
                }



            }

        }

        public List<FacturacionUsuario> obtenerListadoNovedadFacturaXGerenteGeneral()
        {



            var listaNovedadFactura = new List<FacturacionUsuario>();

            string usuario = SessionHelper.GetUser();

            Guid usarioAutenticado = Guid.Parse(usuario);

            using (var ctx = new ModelContext())
            {
                try
                {



                    var Rsulat = (from novFactra in ctx.NovedadFactura
                                  from Usu in ctx.Usuarios
                                  from Serv in ctx.Servicios
                                  from Apro in ctx.AprobacionesFacturas
                                  from cli in ctx.ClientePropuesta
                                  from estadoFactura in ctx.EstadosFactura_Factura
                                  where Usu.UsuarioId == novFactra.IdGerenteCargo
                                  where Serv.ServicioId == novFactra.TipoServicio
                                  where estadoFactura.idFactura == novFactra.FacturaID
                                //  where novFactra.IdDirectorCargo == usarioAutenticado
                                  where novFactra.FacturaID == Apro.FacturaID
                                  where estadoFactura.IdentificadorEstado == 2
                                  where cli.ClienteID == novFactra.IdCliente
                                  where Apro.Director == 2
                                  where usarioAutenticado.ToString() == "2B9E9950-E72D-4BD5-B1F7-B217BA6C2391"

                                  select new FacturacionUsuario()
                                  {
                                      nombreCliente = cli.RazonSocial,
                                      estadoDirector = Apro.Director,
                                      HorasTI = novFactra.TotalHorasAuditoriaTI,
                                      FacturaId = novFactra.FacturaID,
                                      FechaDiligenciamiento = novFactra.FechaDiligenciamiento,
                                      HorasAuditoria = novFactra.Total_auditoría,
                                      HorasImpuestos = novFactra.TotalHorasAuditoriaImpuesto,
                                      HorasLegales = novFactra.TotalHorasAuditoriaJuridica,
                                      TotalHoras = novFactra.TOTALTIEMPO,
                                      HorasOutsorcing = novFactra.Totaloutsourcing,
                                      nombre = Usu.Nombre,
                                      Servicio = Serv.NombreServicio,
                                      estadoGerenciaGeneral = Apro.GerenciaGeneral,
                                      Estado = estadoFactura.IdentificadorEstado.ToString()



                                  }).OrderBy(x => x.FechaDiligenciamiento).ToList();

                    listaNovedadFactura = Rsulat;

                    return listaNovedadFactura;
                }
                catch (Exception e)
                {

                    throw;
                }



            }

        }


        public List<FacturacionUsuario> obtenerListadoNovedadFacturaXAsistenteGerenteGeneral()
        {



            var listaNovedadFactura = new List<FacturacionUsuario>();

            string usuario = SessionHelper.GetUser();

            Guid usarioAutenticado = Guid.Parse(usuario);

            using (var ctx = new ModelContext())
            {
                try
                {



                    var Rsulat = (from novFactra in ctx.NovedadFactura
                                  from Usu in ctx.Usuarios
                                  from Serv in ctx.Servicios
                                  from Apro in ctx.AprobacionesFacturas
                                  from cli in ctx.ClientePropuesta
                                  from estadoFactura in ctx.EstadosFactura_Factura
                                  where Usu.UsuarioId == novFactra.IdGerenteCargo
                                  where Serv.ServicioId == novFactra.TipoServicio
                                  where estadoFactura.idFactura == novFactra.FacturaID
                                  //  where novFactra.IdDirectorCargo == usarioAutenticado
                                  where novFactra.FacturaID == Apro.FacturaID
                                  where estadoFactura.IdentificadorEstado == 2
                                  where cli.ClienteID == novFactra.IdCliente
                                  where Apro.GerenciaGeneral == 2
                                  where usarioAutenticado.ToString() == "4B431CDB-4C34-4D05-81B6-EB7C1AE41B13"

                                  select new FacturacionUsuario()
                                  {
                                      nombreCliente = cli.RazonSocial,
                                      estadoDirector = Apro.Director,
                                      HorasTI = novFactra.TotalHorasAuditoriaTI,
                                      FacturaId = novFactra.FacturaID,
                                      FechaDiligenciamiento = novFactra.FechaDiligenciamiento,
                                      HorasAuditoria = novFactra.Total_auditoría,
                                      HorasImpuestos = novFactra.TotalHorasAuditoriaImpuesto,
                                      HorasLegales = novFactra.TotalHorasAuditoriaJuridica,
                                      TotalHoras = novFactra.TOTALTIEMPO,
                                      HorasOutsorcing = novFactra.Totaloutsourcing,
                                      nombre = Usu.Nombre,
                                      Servicio = Serv.NombreServicio,
                                      estadoGerenciaGeneral = Apro.GerenciaGeneral,
                                      estadeAsistenteGerencia = Apro.AsistenteGerenciaGeneral,
                                      Estado = estadoFactura.IdentificadorEstado.ToString()



                                  }).OrderBy(x => x.FechaDiligenciamiento).ToList();

                    listaNovedadFactura = Rsulat;

                    return listaNovedadFactura;
                }
                catch (Exception e)
                {

                    throw;
                }



            }

        }

        public List<FacturacionUsuario> obtenerListadoNovedadFacturaXContabilidad()

        { 


            var listaNovedadFactura = new List<FacturacionUsuario>();

            string usuario = SessionHelper.GetUser();

            Guid usarioAutenticado = Guid.Parse(usuario);

            using (var ctx = new ModelContext())
            {
                try
                {



                    var Rsulat = (from novFactra in ctx.NovedadFactura
                                  from Usu in ctx.Usuarios
                                  from Serv in ctx.Servicios
                                  from Apro in ctx.AprobacionesFacturas
                                  from cli in ctx.ClientePropuesta
                                  from estadoFactura in ctx.EstadosFactura_Factura
                                  where Usu.UsuarioId == novFactra.IdGerenteCargo
                                  where Serv.ServicioId == novFactra.TipoServicio
                                  where estadoFactura.idFactura == novFactra.FacturaID
                                  //  where novFactra.IdDirectorCargo == usarioAutenticado
                                  where novFactra.FacturaID == Apro.FacturaID
                                  where estadoFactura.IdentificadorEstado == 2
                                  where cli.ClienteID == novFactra.IdCliente
                                
                                  where (Apro.Contabilidad == 1 || Apro.Contabilidad == 2)
                                  where usarioAutenticado.ToString() == "03E22555-AB3A-48A9-8AF7-3D46EEBA4782"

                                  select new FacturacionUsuario()
                                  {
                                      nombreCliente = cli.RazonSocial,
                                      estadoDirector = Apro.Director,
                                      HorasTI = novFactra.TotalHorasAuditoriaTI,
                                      FacturaId = novFactra.FacturaID,
                                      FechaDiligenciamiento = novFactra.FechaDiligenciamiento,
                                      HorasAuditoria = novFactra.Total_auditoría,
                                      HorasImpuestos = novFactra.TotalHorasAuditoriaImpuesto,
                                      HorasLegales = novFactra.TotalHorasAuditoriaJuridica,
                                      TotalHoras = novFactra.TOTALTIEMPO,
                                      HorasOutsorcing = novFactra.Totaloutsourcing,
                                      nombre = Usu.Nombre,
                                      Servicio = Serv.NombreServicio,
                                      estadoGerenciaGeneral = Apro.GerenciaGeneral,
                                      estadeAsistenteGerencia = Apro.AsistenteGerenciaGeneral,
                                      estadoContabilidadl = Apro.Contabilidad,
                                      Estado = estadoFactura.IdentificadorEstado.ToString()



                                  }).OrderBy(x => x.FechaDiligenciamiento).ToList();

                    listaNovedadFactura = Rsulat;

                    return listaNovedadFactura;
                }
                catch (Exception e)
                {

                    throw;
                }



            }

        }



        public FacturacionUsuario obtenerNovedadFacturaIndex(Guid idFacturas)
        {


            var NovedadFactura = new FacturacionUsuario();



            using (var ctx = new ModelContext())
            {
                try
                {



                    var Rsulat = (from novFactra in ctx.NovedadFactura
                                  from usu in ctx.Usuarios
                                  from estdo in ctx.EstadosFactura_Factura
                                  from Ser in ctx.Servicios
                                  from factuaprobacion in ctx.FacturaAprobacion
                                  from EstadoAprobacionFactur in ctx.EstadoAprobacionFactura
                                  where novFactra.IdGerenteCargo == usu.UsuarioId
                                  where novFactra.TipoServicio == Ser.ServicioId
                                 where novFactra.FacturaID == estdo.idFactura
                                 where novFactra.FacturaID == idFacturas
                                 where novFactra.FacturaID == factuaprobacion.idFactura
                                 where factuaprobacion.EstadoAprobacion == factuaprobacion.EstadoAprobacion


                                  select new FacturacionUsuario()
                                  {

                                  FacturaId = novFactra.FacturaID,
                                      nombre = usu.Nombre,
                                      FechaDiligenciamiento = novFactra.FechaDiligenciamiento,
                                      Servicio = Ser.NombreServicio,
                                      //HorasIFRS = novFactra.HorasIFRS,
                                      //HorasTI = novFactra.HorasSistemas,
                                      //HorasImpuestos = novFactra.HorasImpuestos,
                                      //HorasLegales = novFactra.HorasLegales,
                                      //TotalHoras = novFactra.TotalHoras,
                                      //Estado = estdo.IdentificadorEstado,
                                   


                                  }).FirstOrDefault();

                    NovedadFactura = Rsulat;

                    return NovedadFactura;
                }
                catch (Exception e)
                {

                    throw;
                }



            }

        }

        public NovedadFacturaPdf obtenerNovedadFacturaPdf(Guid idFactura)
        {


            var obtenerFactura = new NovedadFacturaPdf();

            using (var ctx = new ModelContext())
            {

                try
                {


                    obtenerFactura = (from novFac in ctx.NovedadFactura
                                      from cliProouesta in ctx.ClientePropuesta
                                      from serv in ctx.Servicios
                                      from gerente in ctx.Usuarios
                                      from director in ctx.Usuarios
                                      from consFactura in ctx.ConsecutivoPrueba
                                      where novFac.FacturaID == idFactura
                                      where novFac.IdCliente == cliProouesta.ClienteID
                                      where novFac.TipoServicio == serv.ServicioId
                                      where gerente.UsuarioId == novFac.IdGerenteCargo
                                      where director.UsuarioId == novFac.IdDirectorCargo
                                      where consFactura.idFactura == novFac.FacturaID
                                      select new NovedadFacturaPdf()
                                      {

                                        fechaDiligenciamiento = novFac.FechaDiligenciamiento,
                                        consecutivoControlTiempos = novFac.ConsecutivoControlTiempo,
                                        RazonSocial = cliProouesta.RazonSocial,
                                        Nit = cliProouesta.Nit,
                                        DV = cliProouesta.Dv,
                                        Direccion = cliProouesta.direccion,
                                        TipoContribuyente = cliProouesta.TipoContribuyente,
                                        Telefono = cliProouesta.Telefono,
                                        Celular = cliProouesta.Celular,
                                        ContactoCliente = cliProouesta.ContactoCliente,
                                        Email = cliProouesta.Email,
                                        nombreServicio = serv.NombreServicio,
                                        Sector = novFac.Sector,
                                        Cliente = novFac.Antiguedad,
                                        numeroContacto = novFac.numeroContrato,
                                        ValorAnualSinIva = novFac.ValorAnualSinIva,
                                        MesesCuotasEjecucion = novFac.MesesCuotasEjecucion,
                                        PorcentajeCuotaInicial = novFac.PorcentajeCuotaInicial,
                                        ValorCuotaInicial = novFac.ValorCuotaInicial,
                                        ValorCoutasMensuales = novFac.ValorCoutasMensuales,
                                        Gravado = novFac.Gravado,
                                        ValorTotalContratoIncluidoIvaAnual = novFac.ValorTotalContratoIncluidoIvaAnual,
                                        FechaInicioContrato = novFac.FechaInicioContrato,
                                        FechaFinalizacionContrato = novFac.FechaFinalizacionContrato,
                                        FechaInicioFacturacion = novFac.FechaInicioFacturacion,
                                        FacturacionMensual = novFac.FacturacionMensual,
                                        FechaEntregaFacturacion = novFac.FechaEntregaFacturacion,
                                        CondicionIniciarFacturacion = novFac.CondicionIniciarFacturacion,
                                        //TextoFacturacionObservaciones = novFac.TextoFacturacionObservaciones,
                                        //HorasImpuestos =novFac.HorasImpuestos,
                                        //  HorasLegales = novFac.HorasLegales,
                                        //  HorasSistemas = novFac.HorasSistemas,
                                        //  HorasIFRS = novFac.HorasIFRS,
                                        //  HorasAuditoria = novFac.HorasAuditoria,
                                        //  TotalHoras = novFac.TotalHoras,
                                          nombreGerente = gerente.Nombre,
                                          nombreDirector = director.Nombre




















                                      }).FirstOrDefault();




                    return obtenerFactura;

                }

                catch (Exception)
                {

                    throw;
                }



            };

        }

        public Factura obtenerNovedadFactura(Guid idFactura) {


            var obtenerFactura = new Factura();

            using (var ctx = new ModelContext()) {

                try
                {


                    obtenerFactura = (from novFac in ctx.NovedadFactura
                                      from cliente in ctx.Clientes
                                      from cliProouesta in ctx.ClientePropuesta
                                      from serv in ctx.Servicios
                                      from gerente in ctx.Usuarios
                                      from director in ctx.Usuarios
                                      from consFactura in ctx.ConsecutivoPrueba
                                      where novFac.FacturaID == idFactura
                                      where novFac.IdCliente == cliProouesta.ClienteID
                                      where novFac.TipoServicio == serv.ServicioId
                                      where gerente.UsuarioId == novFac.IdGerenteCargo
                                      where director.UsuarioId == novFac.IdDirectorCargo
                                      where consFactura.idFactura == novFac.FacturaID
                                      where cliente.NIT == cliProouesta.Nit
                                      select new Factura()
                                      {
                                          
                                          razonSocialCorto = cliente.NombreCliente,
                                          IdDirectorCargo = novFac.IdDirectorCargo,
                                          IdGerenteCargo = novFac.IdGerenteCargo,
                                          facturaId = novFac.FacturaID,
                                          FechaDiligenciamiento = novFac.FechaDiligenciamiento,
                                          ConsecutivoControlTiempo = consFactura.consecutivo.ToString(),
                                          RazonSocial = cliProouesta.RazonSocial,
                                          Nit = cliProouesta.Nit,
                                          Dv = cliProouesta.Dv,
                                          Direccion = cliProouesta.direccion,
                                          TipoContribuyente = novFac.TipoContribuyente,
                                          Telefono = cliProouesta.Telefono,
                                          celular = cliProouesta.Celular,
                                          ContactoCliente = cliProouesta.ContactoCliente,
                                          Email = cliProouesta.Email,
                                          nombreServicio = serv.NombreServicio,
                                          Sector = novFac.Sector,
                                          Antiguedad = novFac.Antiguedad,
                                          numeroContrato = novFac.numeroContrato,
                                          ValorAnualSinIva = novFac.ValorAnualSinIva,
                                          MesesCuotasEjecucion = novFac.MesesCuotasEjecucion,
                                          ManejoCuotaInicial = novFac.ManejoCuotaInicial,
                                          PorcentajeCuotaInicial = novFac.PorcentajeCuotaInicial,
                                          ValorCuotaInicial = novFac.ValorCuotaInicial,
                                          ValorCoutasMensuales = novFac.ValorCoutasMensuales,
                                          ValorMensualSinIva = novFac.ValorMensualSinIva,
                                          Gravado = novFac.Gravado,
                                          ValorTotalContratoIncluidoIvaAnual = novFac.ValorTotalContratoIncluidoIvaAnual,
                                          FechaInicioContrato = novFac.FechaInicioContrato,
                                          FechaFinalizacionContrato = novFac.FechaFinalizacionContrato,
                                          FechaInicioFacturacion = novFac.FechaInicioFacturacion,
                                          FacturacionMensual = novFac.FacturacionMensual,
                                          FechaEntregaFacturacion = novFac.FechaEntregaFacturacion,
                                          TextoFacturacionObservaciones = novFac.TextoFacturacionObservaciones,
                                          //HorasImpuestos = novFac.HorasImpuestos,
                                          //HorasLegales = novFac.HorasLegales,
                                          //HorasIFRS = novFac.HorasIFRS,
                                          //HorasSistemas = novFac.HorasSistemas,
                                          //HorasAuditoria = novFac.HorasAuditoria,
                                          //TotalHoras = novFac.TotalHoras,
                                          nombreGerente = gerente.Nombre,
                                          nombreDirector = director.Nombre,
                                          año = novFac.horasAno,
                                          añoProx = novFac.horasAnoProx,
                                          asistenteAuditoria = novFac.Asistente_auditoría,
                                          asistenteAuditoriaProx = novFac.AauditoriaProx,
                                          auditorJunior = novFac.Auditor_Junior,
                                          auditorJuniorProx = novFac.AjuniorAprox,
                                          auditorSemisenior = novFac.Auditor_Semisenior,
                                          auditorSemiseniorProx = novFac.ASemiseniorAprox,
                                          auditorSenior = novFac.Auditor_Senior,
                                          auditorSeniorProx = novFac.ASeniorAprox,
                                          supervisoJunior = novFac.Supervisor_Junior,
                                          supervisoJuniorProx = novFac.SjuniorAprox,
                                          supervisoSemi = novFac.Supervisor_Semisenior,
                                          supervisoSemiProx = novFac.SsemiseniorAprox,
                                          supervisoSenior = novFac.Supervisor_Senior,
                                          supervisoSeniorProx = novFac.SseniorAprox,
                                          gerenteJunior = novFac.Gerente_Junior,
                                          gerenteJuniorAprox = novFac.GJuniorAprox,
                                          gerenteSemi = novFac.Gerente_Semisenior,
                                          gerenteSemirAprox = novFac.GSemiAprox,
                                          gerenteSenior = novFac.Gerente_Senior,
                                          gerenteSeniorAprox = novFac.GSeniorAprox,
                                          directorJunior = novFac.Director_Junior,
                                          directorJuniorAprox = novFac.DJuniorAprox,
                                          directorSemi = novFac.Director_Semisenior,
                                          directorSemirAprox = novFac.DSemiAprox,
                                          directorSenior = novFac.Director_Senior,
                                          directorSeniorAprox = novFac.DSeniorAprox,
                                          totalHorasAuditoria = novFac.Total_auditoría,
                                          totalHorasAuditoriaProx = novFac.vaueAuditoriaAprox,
                                          auditorTI = novFac.Auditor_TI,
                                          auditoraTIProx = novFac.AuditorTIAprox,
                                          SupervisorTI = novFac.Supervisor_TI,
                                          SupervisorTIProx = novFac.supervisorTIAprox,
                                          GerenteTI = novFac.Gerente_TI,
                                          GerenteTIProx = novFac.GerenteTIAprox,
                                          AuditorImpuesto = novFac.Auditor_impuestos,
                                          AuditorImpuestoProx = novFac.AuditorImpuestoAprox,
                                          GerenteImpuesto = novFac.Gerente_impuestos,
                                          GerenteImpuestoProx = novFac.GImpuestosAprox,
                                          AsesorJuridico = novFac.Asesor_Jurídico,
                                          AsesorJuridicoProx = novFac.AsesorJuridicoProx,
                                          GerenteJuridicio = novFac.Gerente_Jurídico,
                                          GerenteJuridicioProx = novFac.GJuridicoAprox,
                                          totalHorasEsepcializadas = novFac.Total_especialistas,
                                          totalHorasEsepcializadasProx = novFac.valueEx,
                                          Total = novFac.TOTALTIEMPO,
                                          TotalAprox = novFac.RsultTotalAprox,
                                          IdCliente = cliProouesta.ClienteID,
                                          ServicioId = serv.ServicioId,
                                          GreneteOut = novFac.OutGerenteval,
                                          GreneteOutProx = novFac.OutGerentevalAprox,
                                          supervisorOut = novFac.outSupervisorVal,
                                          supervisorOutProx = novFac.outSupervisorValProx,
                                          CoordinadorOut = novFac.outcordinadorVal,
                                          CoordinadorOutProx = novFac.outcordinadorValProx,
                                          AnalistaOut = novFac.outAnalistaVal,
                                          AnalistaOudProx = novFac.outAnalistaValProx,
                                          AuxiliarOut = novFac.outAuxiliarVal,
                                          AuxiliarOutProx = novFac.outAuxiliarValProx,
                                          rsultOut = novFac.RsultTotalesOut,
                                          rsultOutProx = novFac.RsultTotalAproxes,
                                          CondicionIniciarFacturacion = novFac.CondicionIniciarFacturacion,
                                          ProcentajeventaCargo1 = novFac.ProcentajeventaCargo1,
                                          ventaCargo1 = novFac.ventaCargo1,
                                          ProcentajeventaCargo2 = novFac.ProcentajeventaCargo2,
                                          ventaCargo2 = novFac.ventaCargo2,
                                          ProcentajeventaCargo3 = novFac.ProcentajeventaCargo3,
                                          ventaCargo3 = novFac.ventaCargo3,
                                          nombreCliente = cliProouesta.RazonSocial

                                      








                                      }).FirstOrDefault();




                    return obtenerFactura;

                }

                catch (Exception)
                {

                    throw;
                }



            };

        }

        public void voidGuardarEstado(int idEstado , Guid factura) {

            var estado = new EstadosFactura_Factura();
            estado.IdentificadorEstado = idEstado;
            estado.idFactura = factura;

            using (var ctx = new ModelContext()) {


                ctx.Entry(estado).State = System.Data.Entity.EntityState.Added;
                ctx.SaveChanges();





            };


        }


        public void ModificarTiempo(string HorasTiEditar, string TotalHorasEditar, string HorasServicioEditar, string HorasLegalesEditar, string HorasIMPUESTOSEditar, string HorasifrsEditar, string idfactura)
        {
            using (var ctx = new ModelContext())
            {



                ctx.Database.ExecuteSqlCommand(
                           "Update  NovedadFactura  set HorasImpuestos = @Impuesto   WHERE FacturaID = @id",
                           new SqlParameter("Impuesto", HorasIMPUESTOSEditar),
                            new SqlParameter("id", idfactura)
                       );

                ctx.Database.ExecuteSqlCommand(
                           "Update  NovedadFactura  set HorasLegales = @legales   WHERE FacturaID = @id",
                           new SqlParameter("legales", HorasLegalesEditar),
                            new SqlParameter("id", idfactura)
                       );
                ctx.Database.ExecuteSqlCommand(
                         "Update  NovedadFactura  set HorasSistemas = @sistemas   WHERE FacturaID = @id",
                         new SqlParameter("sistemas", HorasTiEditar),
                          new SqlParameter("id", idfactura)
                     );
                ctx.Database.ExecuteSqlCommand(
                       "Update  NovedadFactura  set HorasIFRS = @HorasifrsEditar   WHERE FacturaID = @id",
                       new SqlParameter("HorasifrsEditar", HorasifrsEditar),
                        new SqlParameter("id", idfactura)
                   );
                ctx.Database.ExecuteSqlCommand(
                     "Update  NovedadFactura  set HorasAuditoria = @HorasServicioEditar   WHERE FacturaID = @id",
                     new SqlParameter("HorasServicioEditar", HorasServicioEditar),
                      new SqlParameter("id", idfactura)
                 );

                ctx.Database.ExecuteSqlCommand(
                    "Update  NovedadFactura  set TotalHoras = @TotalHorasEditar   WHERE FacturaID = @id",
                    new SqlParameter("TotalHorasEditar", TotalHorasEditar),
                     new SqlParameter("id", idfactura)
                );


                ctx.SaveChanges();

            }

            }


        public void EliminarFactura(Guid idfactura)
        {
            using (var ctx = new ModelContext())
            {



                ctx.Database.ExecuteSqlCommand(
                           "Update  EstadosFactura_Factura  set IdentificadorEstado = 3   WHERE idFactura = @id",
                      
                            new SqlParameter("id", idfactura)
                       );

              

                ctx.SaveChanges();

            }

        }


        public void EditarNombreCOntato(Guid IdCliente , string nombre)
        {
            using (var ctx = new ModelContext())
            {



                ctx.Database.ExecuteSqlCommand(
                           "Update  ClientePropuesta  set  ContactoCliente=@ContactoCliente  WHERE ClienteID = @ClienteID",

                            new SqlParameter("ClienteID", IdCliente),
                             new SqlParameter("ContactoCliente", nombre)

                       );



                ctx.SaveChanges();

            }

        }

        public void EditarCelularContato(Guid IdCliente, string celular)
        {
            using (var ctx = new ModelContext())
            {



                ctx.Database.ExecuteSqlCommand(
                           "Update  ClientePropuesta  set  Celular=@Celular  WHERE ClienteID=@ClienteID",

                            new SqlParameter("ClienteID", IdCliente),
                             new SqlParameter("Celular", celular)

                       );



                ctx.SaveChanges();

            }

        }
        

       public void EditarTelefonoContato(Guid IdCliente, string telefono)
        {
            using (var ctx = new ModelContext())
            {



                ctx.Database.ExecuteSqlCommand(
                           "Update  ClientePropuesta  set  Telefono=@telefono  WHERE ClienteID=@ClienteID",

                            new SqlParameter("ClienteID", IdCliente),
                             new SqlParameter("telefono", telefono)

                       );



                ctx.SaveChanges();

            }

        }

        public void EditarDireccionContato(Guid IdCliente, string direccion)
        {
            using (var ctx = new ModelContext())
            {



                ctx.Database.ExecuteSqlCommand(
                           "Update  ClientePropuesta  set  direccion=@direccion  WHERE ClienteID=@ClienteID",

                            new SqlParameter("ClienteID", IdCliente),
                             new SqlParameter("direccion", direccion)

                       );



                ctx.SaveChanges();

            }

        }

        public void EditarEmailContato(Guid IdCliente, string email)
        {
            using (var ctx = new ModelContext())
            {



                ctx.Database.ExecuteSqlCommand(
                           "Update  ClientePropuesta  set  Email=@email  WHERE ClienteID=@ClienteID",

                            new SqlParameter("ClienteID", IdCliente),
                             new SqlParameter("email", email)

                       );



                ctx.SaveChanges();

            }

        }

        public string AprobarDirector(Guid factura, string mensaje)
        {


            Factura nf = new Factura();

            nf = obtenerNovedadFactura(factura);




            var estado = new EstadosFactura_Factura();

            using (var ctx = new ModelContext())
            {



                ctx.Database.ExecuteSqlCommand(
                           "Update  AprobacionesFacturas  set Director = 2   WHERE FacturaID = @id",
                           new SqlParameter("id", factura)
                       );






                //ctx.Entry(estado).State = System.Data.Entity.EntityState.Unchanged;
                // ctx.Entry(estado).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();


                string asunto = "La novedad de facturación del cliente " + nf.nombreCliente + " con el gerente  " + nf.nombreGerente + " requiere aprobación de gerencia general";

                guardarMensaje(factura, mensaje, "Aprobacion Director");


                correoElectronico.EnviarCorreoUsuario("avivian@amezquita.com.co", asunto ,"");


                FacturacionUsuario index = obtenerNovedadFacturaIndex(factura);


                string data = JsonConvert.SerializeObject(index, Formatting.Indented);


                return data;



            }


        }


        public string AprobarContabilidad(Guid factura, string mensaje , string email)
        {



            Factura nf = new Factura();

            nf = obtenerNovedadFactura(factura);

            string Asunto = "La novedad de facturacion del cliente  " + nf.nombreCliente + " con el  gerente " + nf.nombreGerente + " require ser aprobada";
            string Mensaje = mensaje;

            var estado = new EstadosFactura_Factura();

            using (var ctx = new ModelContext())
            {



                ctx.Database.ExecuteSqlCommand(
                           "Update  AprobacionesFacturas  set Contabilidad = 2   WHERE FacturaID = @id",
                           new SqlParameter("id", factura)
                       );






                //ctx.Entry(estado).State = System.Data.Entity.EntityState.Unchanged;
                // ctx.Entry(estado).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();




                guardarMensaje(factura, mensaje, "Aprobacion Contabilidad");

                correoElectronico.EnviarCorreoUsuario(email, Asunto , Mensaje);

                FacturacionUsuario index = obtenerNovedadFacturaIndex(factura);


                string data = JsonConvert.SerializeObject(index, Formatting.Indented);


                return data;



            }


        }

        public string obtenerCorreoUsuarioCreador(Guid idFactura)
        {

            using (var ctx = new ModelContext())
            {
                try
                {
                    var rSult = ctx.Database.SqlQuery<string>("obtenerEmailUsuario @idFactura", new SqlParameter("idFactura", idFactura)).FirstOrDefault();


                    return rSult.ToString();

                }
                catch
                {
                    throw;
                }
            }



        }



        public string obtenerCorreoDirectorCreador(Guid idFactura)
        {

            using (var ctx = new ModelContext())
            {
                try
                {
                    var rSult = ctx.Database.SqlQuery<string>("obtenerEmailDirector @idFactura", new SqlParameter("idFactura", idFactura)).FirstOrDefault();


                    return rSult.ToString();

                }
                catch
                {
                    throw;
                }
            }



        }

        public string AprobarGerenteGeneral(Guid factura, string mensaje)
        {


            var estado = new EstadosFactura_Factura();

            using (var ctx = new ModelContext())
            {

                Factura nf = new Factura();

                nf = obtenerNovedadFactura(factura);

                ctx.Database.ExecuteSqlCommand(
                           "Update  AprobacionesFacturas  set GerenciaGeneral = 2   WHERE FacturaID = @id",
                           new SqlParameter("id", factura)
                       );

                
                //ctx.Entry(estado).State = System.Data.Entity.EntityState.Unchanged;
                // ctx.Entry(estado).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();


                guardarMensaje(factura, mensaje, "Aprobacion Gerente General");


                string asunto = "La novedad de facturación del cliente " + nf.nombreCliente + " con el gerente  " + nf.nombreGerente + " requiere aprobación de Asistente de General";

                FacturacionUsuario index = obtenerNovedadFacturaIndex(factura);

                correoElectronico.EnviarCorreoUsuario("cjenny@amezquita.com.co", asunto, "");


                string data = JsonConvert.SerializeObject(index, Formatting.Indented);


                return data;



            }


        }

        public string AprobarAsistenteGerenteGeneral(Guid factura, string mensaje)
        {


            var estado = new EstadosFactura_Factura();

            using (var ctx = new ModelContext())
            {


             //   crearProyectoControlTiempos(factura);

                ctx.Database.ExecuteSqlCommand(
                           "Update  AprobacionesFacturas  set AsistenteGerenciaGeneral = 2   WHERE FacturaID = @id",
                           new SqlParameter("id", factura)
                       );


                //ctx.Entry(estado).State = System.Data.Entity.EntityState.Unchanged;
                // ctx.Entry(estado).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();


             

                guardarMensaje(factura, mensaje, "Aprobacion Asistente Gerente General");


                crearProyectoControlTiempos(factura);

                FacturacionUsuario index = obtenerNovedadFacturaIndex(factura);


                string data = JsonConvert.SerializeObject(index, Formatting.Indented);


                return data;



            }


        }

        public void crearProyectoControlTiempos(Guid factura)
        {

            Factura novedad = obtenerNovedadFactura(factura);


            Guid usuario = new Guid("5F8AC4CB-A8C1-4147-9A76-638C67B92DFF");

            
            string año = novedad.FechaInicioContrato.Year.ToString();
            int añoEntero = Convert.ToInt32(año);
            DateTime fechaInicio = novedad.FechaInicioContrato;
            DateTime fechafinalizacion = novedad.FechaFinalizacionContrato;
            decimal bolsaHoras = Convert.ToDecimal(novedad.Total);
            Guid director = novedad.IdDirectorCargo;
            Guid gerente = novedad.IdGerenteCargo;
            Guid auditor = novedad.IdGerenteCargo;
            Guid servicio = novedad.ServicioId;
            Guid supervisor = novedad.IdGerenteCargo;
            Guid cliente = obtenerIdNovedadFactura(novedad.Nit);
          
            Guid proyectoId = Guid.NewGuid();
            string nombreProyecto = (novedad.nombreServicio + " - " + novedad.razonSocialCorto + " - " + año).ToUpper();


            try
            {



                using (var ctx = new ModelContext())
                {




                    ctx.Database.ExecuteSqlCommand(
                               "insert into Proyectos (ProyectoId,NombreProyecto ,año,FechaInicio,FechaFinal,BolsaHoras,AuditorId,ClienteId,DirectorId,GerenteId,SupervisorId)values(@proyectoId,@nombreProyecto,@año,@fechaInicio,@fechaFinal,@BolsaHoras,@auditor,@clienteId,@directorId,@GerenteId,@SupervisorId)",
                                     new SqlParameter("proyectoId", proyectoId),
                                    new SqlParameter("nombreProyecto", nombreProyecto),
                                    new SqlParameter("año", añoEntero),
                                    new SqlParameter("fechaInicio", fechaInicio),
                                    new SqlParameter("fechaFinal", fechafinalizacion),
                                    new SqlParameter("BolsaHoras", bolsaHoras),
                                    new SqlParameter("auditor", usuario),
                                    new SqlParameter("clienteId", cliente),
                                    new SqlParameter("directorId", director),
                                    new SqlParameter("GerenteId", gerente),
                                    new SqlParameter("SupervisorId", usuario)


                    );


                    ctx.SaveChanges();

                }

                using (var ctx2 = new ModelContext())
                {




                    ctx2.Database.ExecuteSqlCommand(
                               "insert into ServiciosProyecto (ProyectoId,ServicioId)values(@proyectoId,@ServicioId)",
                                     new SqlParameter("proyectoId", proyectoId),
                                    new SqlParameter("@ServicioId", servicio)
                                    


                    );


                    ctx2.SaveChanges();

                }



            }


            catch (Exception)
            {

                throw;
            }



            try
            {

                Guid IdProyecto = obteneridProyecto(nombreProyecto, añoEntero, bolsaHoras, director, gerente);

                using (var ctx = new ModelContext())
                {



                    ctx.Database.ExecuteSqlCommand(
                        "sp_amezquita_agregarGuporTrabajoFacturacion @IdProyecto , @IdGERENTE  ",
                         new SqlParameter("@IdProyecto", IdProyecto),
                         new SqlParameter("@IdGERENTE", gerente)
                        );
                }

            }
            catch (Exception)
            {

                throw;
            }



        


        
            }




        public Guid obteneridProyecto( string nombreProyecto , int año , decimal bolsasHoras , Guid idDirector , Guid idGerente) {

            using (var ctx = new ModelContext())
            {

                var proyectos = (from proyecto in ctx.Proyectos
                               where proyecto.NombreProyecto == nombreProyecto
                               where proyecto.Año == año
                               where proyecto.BolsaHoras == bolsasHoras
                               where proyecto.DirectorId == idDirector
                               where proyecto.GerenteId == idGerente
                               select new ProyectoE
                               {


                                   proyectoId = proyecto.ProyectoId


                               }).FirstOrDefault(); 


                Guid proyectoId = proyectos.proyectoId;

                return proyectoId;


            }




        }


        public Guid obtenerIdNovedadFactura(string nit) {

            using (var ctx = new ModelContext())
            {

             var  cliente = (ctx.Clientes.Where(x => x.NIT == nit)
                                                        .SingleOrDefault());



                Guid idCliente = cliente.ClienteId;

                return idCliente;


            }


         


            }



        //metodo que pasa a probacion director
        public string actualizarEstado(Guid factura , string mensaje ) {


            var estado = new EstadosFactura_Factura();

            using (var ctx = new ModelContext()) {



                ctx.Database.ExecuteSqlCommand(
                           "Update  EstadosFactura_Factura  set IdentificadorEstado = 2   WHERE idFactura = @id",
                           new SqlParameter("id", factura)
                       );

                ctx.Database.ExecuteSqlCommand(
                        "Update  estadoAprobacionArea  set EstadoFiscal = 2   WHERE idFactura = @id",
                        new SqlParameter("id", factura)
                    );


               



                //ctx.Entry(estado).State = System.Data.Entity.EntityState.Unchanged;
                // ctx.Entry(estado).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();


                guardarMensaje(factura ,mensaje , "Pasa Aprobacion");


                var facturaInformacion = obtenerNovedadFactura(factura);



                string cuerpoCorreo = "La novedad de facturacion del cliente " + facturaInformacion.nombreCliente + " con el  gerente " + facturaInformacion.nombreGerente + " y director " + facturaInformacion.nombreDirector + " requiere aprobacion ";
                cuerpoCorreo += " nf.amezquita.com.co";


                correoElectronico.EnviarCorreoUsuario("pmilena@amezquita.com.co","APROBACION CONTABILIDAD", cuerpoCorreo);

                FacturacionUsuario index = obtenerNovedadFacturaIndex(factura);


                string data = JsonConvert.SerializeObject(index, Formatting.Indented);


                return data;

               

            }


        }


        public string RechazarFactura(Guid factura, string mensaje , string Cargo , string usuarioRechaza , string correo)
        {

            Factura nf = new Factura();

            nf = obtenerNovedadFactura(factura);



            string AsuntoCorreo = "";
            var mensajesCargo = "";

            using (var ctx = new ModelContext())
            {



                ctx.Database.ExecuteSqlCommand(
                           "Update  AprobacionesFacturas  set Director = 1   WHERE FacturaID = @id",
                           new SqlParameter("id", factura)
                       );

                ctx.Database.ExecuteSqlCommand(
                       "Update  AprobacionesFacturas  set GerenciaGeneral = 1   WHERE FacturaID = @id",
                       new SqlParameter("id", factura)
                   );

                ctx.Database.ExecuteSqlCommand(
                      "Update  AprobacionesFacturas  set AsistenteGerenciaGeneral = 1   WHERE FacturaID = @id",
                      new SqlParameter("id", factura)
                  );


                ctx.Database.ExecuteSqlCommand(
                      "Update  AprobacionesFacturas  set Contabilidad = 1   WHERE FacturaID = @id",
                      new SqlParameter("id", factura)
                  );


                ctx.Database.ExecuteSqlCommand(
                   "Update  EstadosFactura_Factura  set IdentificadorEstado = 1   WHERE idFactura = @id",
                   new SqlParameter("id", factura)
               );

               


                if (Cargo == "GerenteGeneral")
                {

                    mensajesCargo = "Rechazado Gerente General";
                    mensajesCargo = "Rechazado por Gerencia Genreal";
                    AsuntoCorreo = "La novedad de factura del cliente " + nf.nombreCliente + " fue rechazada Gerencia General " + usuarioRechaza;

                    mensaje += " nf.amezquita.com.co";
                    correoElectronico.EnviarCorreoUsuario(correo, AsuntoCorreo, mensaje);

                }

             

                 if (Cargo == "AsistenteGerenteGeneral")
                {

                    mensajesCargo = "Rechazado por Asitente Gerencia Genreal";
                    AsuntoCorreo = "La novedad de factura del cliente " + nf.nombreCliente + " fue rechazada Asistente Gerencia General " + usuarioRechaza;

                    mensaje += " nf.amezquita.com.co";
                    correoElectronico.EnviarCorreoUsuario(correo, AsuntoCorreo, mensaje);

                }



              


                if (Cargo == "Director") {

                    mensajesCargo = "Rechazado director";
                    mensajesCargo = "Rechazado por Director";
                    AsuntoCorreo = "La novedad de factura del cliente " + nf.nombreCliente + " fue rechazada  por el director " + usuarioRechaza;

                    mensaje += " nf.amezquita.com.co";
                    correoElectronico.EnviarCorreoUsuario(correo, AsuntoCorreo, mensaje);

                }

                if (Cargo == "Contabilidad")
                {

                    mensajesCargo = "Rechazado por contabilidad";
                    AsuntoCorreo = "La novedad de factura del cliente " + nf.nombreCliente + " fue rechazada por contabilidad por el usuario " + usuarioRechaza ;

                    mensaje += " nf.amezquita.com.co";
                    correoElectronico.EnviarCorreoUsuario(correo, AsuntoCorreo , mensaje);


                }




                //ctx.Entry(estado).State = System.Data.Entity.EntityState.Unchanged;
                // ctx.Entry(estado).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();


                guardarMensaje(factura, mensaje, mensajesCargo);

                FacturacionUsuario index = obtenerNovedadFacturaIndex(factura);


                string data = JsonConvert.SerializeObject(index, Formatting.Indented);


                return data;



            }


        }


        public string AprobacionArea(Guid factura, string mensaje , int Area)
        {



         

            var estado = new EstadosFactura_Factura();

            using (var ctx = new ModelContext())
            {


                if(Area == 1 )
                ctx.Database.ExecuteSqlCommand(
                           "Update estadoAprobacionArea  set EstadoHorasIT = 2   WHERE IdFactura = @id",
                           new SqlParameter("id", factura)
                          
                );

                if (Area == 2)
                    ctx.Database.ExecuteSqlCommand(
                               "Update estadoAprobacionArea  set EstadosHorasImpuestos = 2   WHERE IdFactura = @id",
                               new SqlParameter("id", factura)

                );

                if (Area == 3)
                    ctx.Database.ExecuteSqlCommand(
                               "Update estadoAprobacionArea  set EstadoHorasIFRS = 2   WHERE IdFactura = @id",
                               new SqlParameter("id", factura)

                );

                if (Area == 4)
                    ctx.Database.ExecuteSqlCommand(
                               "Update estadoAprobacionArea  set EstadoHorasLegal = 2   WHERE IdFactura = @id",
                               new SqlParameter("id", factura)

                );





                //ctx.Entry(estado).State = System.Data.Entity.EntityState.Unchanged;
                // ctx.Entry(estado).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();

                string Mensajesistema = "";

                if (Area == 1) {

                    Mensajesistema = "Aprobacion de TI POR ";

                }
                if (Area == 2)
                {

                    Mensajesistema = "Aprobacion de IMPUESTO POR ";

                }


                guardarMensaje(factura, mensaje, Mensajesistema);

                FacturacionUsuario index = obtenerNovedadFacturaIndex(factura);


                string data = JsonConvert.SerializeObject(index, Formatting.Indented);


                return data;



            }


        }


        public string EliminarArea(Guid factura, string mensaje, int Area)
        {





            var estado = new EstadosFactura_Factura();

            using (var ctx = new ModelContext())
            {


                if (Area == 1)
                    ctx.Database.ExecuteSqlCommand(
                               "Update estadoAprobacionArea  set EstadoHorasIT = 3   WHERE IdFactura = @id",
                               new SqlParameter("id", factura)

                    );

                if (Area == 2)
                    ctx.Database.ExecuteSqlCommand(
                               "Update estadoAprobacionArea  set EstadosHorasImpuestos = 3   WHERE IdFactura = @id",
                               new SqlParameter("id", factura)

                );

                if (Area == 3)
                    ctx.Database.ExecuteSqlCommand(
                               "Update estadoAprobacionArea  set EstadoHorasIFRS = 3   WHERE IdFactura = @id",
                               new SqlParameter("id", factura)

                );

                if (Area == 4)
                    ctx.Database.ExecuteSqlCommand(
                               "Update estadoAprobacionArea  set EstadoHorasLegal = 3   WHERE IdFactura = @id",
                               new SqlParameter("id", factura)

                );





                //ctx.Entry(estado).State = System.Data.Entity.EntityState.Unchanged;
                // ctx.Entry(estado).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();

                string Mensajesistema = "";

                if (Area == 1)
                {

                    Mensajesistema = "rechazado de TI POR ";

                }
                if (Area == 2)
                {

                    Mensajesistema = "rechazado de IMPUESTO POR ";

                }

                if (Area == 3)
                {

                    Mensajesistema = "rechazado de IFRS POR ";

                }
                if (Area == 4)
                {

                    Mensajesistema = "rechazado de Legal POR ";

                }


                guardarMensaje(factura, mensaje, Mensajesistema);

                FacturacionUsuario index = obtenerNovedadFacturaIndex(factura);


                string data = JsonConvert.SerializeObject(index, Formatting.Indented);


                return data;



            }


        }



        public string ActualizarTiemporArea(Guid factura, string mensaje, int Area , int tiempoNuevo)
        {





            var estado = new EstadosFactura_Factura();

            using (var ctx = new ModelContext())
            {


                if (Area == 1)
                {
                    ctx.Database.ExecuteSqlCommand(
                               "Update NovedadFactura  set HorasSistemas =  @tiempoNuevo   WHERE FacturaID = @id",
                               new SqlParameter("id", factura),
                                 new SqlParameter("tiempoNuevo", tiempoNuevo)

                    );
                    ctx.Database.ExecuteSqlCommand(
                                   "Update estadoAprobacionArea  set EstadoHorasIT = 1   WHERE IdFactura = @id",
                                   new SqlParameter("id", factura)

                        );
                }
                if (Area == 2)
                {
                    ctx.Database.ExecuteSqlCommand(
                               "Update NovedadFactura  set HorasImpuestos =  @tiempoNuevo   WHERE IdFactura = @id",
                               new SqlParameter("id", factura),
                                 new SqlParameter("tiempoNuevo", tiempoNuevo)

                );
                                ctx.Database.ExecuteSqlCommand(
                           "Update estadoAprobacionArea  set EstadosHorasImpuestos = 1   WHERE IdFactura = @id",
                           new SqlParameter("id", factura)

                );
                }
                if (Area == 3)
                {
                    ctx.Database.ExecuteSqlCommand(
                           "Update NovedadFactura  set HorasIFRS =  @tiempoNuevo   WHERE IdFactura = @id",
                               new SqlParameter("id", factura),
                                 new SqlParameter("tiempoNuevo", tiempoNuevo)

                );
                    ctx.Database.ExecuteSqlCommand(
                                "Update estadoAprobacionArea  set EstadoHorasIFRS = 1   WHERE IdFactura = @id",
                                new SqlParameter("id", factura)

                     );
                }
                if (Area == 4)
                {
                    ctx.Database.ExecuteSqlCommand(
                                "Update NovedadFactura  set HorasLegales =  @tiempoNuevo   WHERE IdFactura = @id",
                               new SqlParameter("id", factura),
                                 new SqlParameter("tiempoNuevo", tiempoNuevo)



                );

                    ctx.Database.ExecuteSqlCommand(
                             "Update estadoAprobacionArea  set EstadoHorasLegal = 1   WHERE IdFactura = @id",
                             new SqlParameter("id", factura)

                  );

                }



                //ctx.Entry(estado).State = System.Data.Entity.EntityState.Unchanged;
                // ctx.Entry(estado).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();

                string Mensajesistema = "";

                if (Area == 1)
                {

                    Mensajesistema = "Modificada horas TI POR ";

                }
                if (Area == 2)
                {

                    Mensajesistema = "Modificada horas TI  POR ";

                }

                if (Area == 3)
                {

                    Mensajesistema = "Modificada horas   IFRS POR ";

                }
                if (Area == 4)
                {

                    Mensajesistema = "Modificada horas  Legal POR ";

                }


                guardarMensaje(factura, mensaje, Mensajesistema);

                FacturacionUsuario index = obtenerNovedadFacturaIndex(factura);


                string data = JsonConvert.SerializeObject(index, Formatting.Indented);


                return data;



            }


        }

        public void consecutivo(Guid factura)
        {


            var estado = new EstadosFactura_Factura();

            using (var ctx = new ModelContext())
            {



                ctx.Database.ExecuteSqlCommand(
                           "insert into ConsecutivoPrueba (idFactura) values(@id)",
                           new SqlParameter("id", factura)
                       );






                //ctx.Entry(estado).State = System.Data.Entity.EntityState.Unchanged;
                // ctx.Entry(estado).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();



            }


        }

        public void guardarMensaje(Guid factura , string MensajeUsuario , string MensajeSistema)
        {


            var estado = new EstadosFactura_Factura();

            using (var ctx = new ModelContext())
            {


                DateTime fechaInicio = DateTime.Now;
                string usuario = SessionHelper.GetUser();

                Guid usarioAutenticado = Guid.Parse(usuario);
                ctx.Database.ExecuteSqlCommand(
                           "insert into MensajeFactura (IdFactura,MensajeUsuario,MensajeSistema,fecha,idUsuario) values(@idFactura,@MensajeUsuario,@MensajeSistema,@fecha,@idUsuario)",
                           new SqlParameter("idFactura", factura),
                           new SqlParameter("MensajeUsuario", MensajeUsuario),
                           new SqlParameter("MensajeSistema", MensajeSistema),
                           new SqlParameter("fecha", fechaInicio),
                           new SqlParameter("idUsuario", usarioAutenticado)
                       );






                //ctx.Entry(estado).State = System.Data.Entity.EntityState.Unchanged;
                // ctx.Entry(estado).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();



            }


        }

        public void aprobacionHoraIT(Guid factura , int TotaHoras , int area) {


            using (var ctx = new ModelContext())
            {

                ctx.Database.ExecuteSqlCommand(
                         "insert into FacturaAprobacion (IdArea,TotalHoras,EstadoAprobacion,idFactura) values(@IdArea,@TotalHoras,@EstadoAprobacion,@idFactura)",
                         new SqlParameter("idFactura", factura),
                         new SqlParameter("EstadoAprobacion", 1),
                         new SqlParameter("TotalHoras", TotaHoras),
                         new SqlParameter("IdArea", area)
                        
                     );
            }




        }

        public void aprobacionHoraImpuestos(Guid factura, int TotaHoras, int area)
        {


            using (var ctx = new ModelContext())
            {

                ctx.Database.ExecuteSqlCommand(
                         "insert into FacturaAprobacion (IdArea,TotalHoras,EstadoAprobacion,idFactura) values(@IdArea,@TotalHoras,@EstadoAprobacion,@idFactura)",
                         new SqlParameter("idFactura", factura),
                         new SqlParameter("EstadoAprobacion", 1),
                         new SqlParameter("TotalHoras", TotaHoras),
                         new SqlParameter("IdArea", area)

                     );
            }




        }

        public List<FacturaAprobaciones> FacturasAprobaciones() {


            string usuario = SessionHelper.GetUser();

            
            Guid usarioAutenticado = Guid.Parse(usuario);
            var facturaAprobacion = new List<FacturaAprobaciones>();

            using (var ctx = new ModelContext()) {


             //   facturaAprobacion = ctx.FacturaAprobacion.ToList();



                facturaAprobacion = (from estadoAprobacionArea in ctx.estadoAprobacionArea
                                     from novedadFactura in ctx.NovedadFactura
                                     from cliente in ctx.ClientePropuesta
                                     from EstadosFactura_Facturas in ctx.EstadosFactura_Factura
                                     from gerenteUusario in ctx.Usuarios
                                         //   from areas in ctx.AreasAprobacion
                                     where cliente.ClienteID == novedadFactura.IdCliente
                                     where novedadFactura.FacturaID == estadoAprobacionArea.IdFactura
                                     where EstadosFactura_Facturas.idFactura == novedadFactura.FacturaID
                                     where EstadosFactura_Facturas.IdentificadorEstado == 2
                                     where gerenteUusario.UsuarioId == novedadFactura.IdGerenteCargo




                                     select new FacturaAprobaciones()
                                     {

                                         //TotalLegal = novedadFactura.HorasLegales,

                                         //TotalIFRS = novedadFactura.HorasIFRS,
                                         //totalHoras = novedadFactura.TotalHoras,
                                         //totalSistema = novedadFactura.HorasSistemas,
                                         //totalImpuestos = novedadFactura.HorasImpuestos,
                                         estadoIt = estadoAprobacionArea.EstadoHorasIT,
                                         estadoImpuesto = estadoAprobacionArea.EstadosHorasImpuestos,
                                         estadoAuditoria = estadoAprobacionArea.EstadoFiscal,
                                         estadoIFRS = estadoAprobacionArea.EstadoHorasIFRS,
                                         estadoLegal = estadoAprobacionArea.EstadoHorasLegal,

                                         NombreCliente = cliente.RazonSocial,
                                         idFactura = novedadFactura.FacturaID,
                                         gerente = gerenteUusario.Nombre,
                                         fechaCreacion = novedadFactura.FechaDiligenciamiento


                                     }).ToList();
                                    





                return facturaAprobacion;

            } ;



        }


        public List<FacturaAprobaciones> FacturasAprobacionesAuxliarGerencia()
        {


            string usuario = SessionHelper.GetUser();


            Guid usarioAutenticado = Guid.Parse(usuario);
            var facturaAprobacion = new List<FacturaAprobaciones>();

            using (var ctx = new ModelContext())
            {


                //   facturaAprobacion = ctx.FacturaAprobacion.ToList();



                facturaAprobacion = (from estadoAprobacionArea in ctx.estadoAprobacionArea
                                     from novedadFactura in ctx.NovedadFactura
                                     from cliente in ctx.ClientePropuesta
                                     from EstadosFactura_Facturas in ctx.EstadosFactura_Factura
                                     from gerenteUusario in ctx.Usuarios
                                         //   from areas in ctx.AreasAprobacion
                                     where cliente.ClienteID == novedadFactura.IdCliente
                                     where novedadFactura.FacturaID == estadoAprobacionArea.IdFactura
                                     where EstadosFactura_Facturas.idFactura == novedadFactura.FacturaID
                                     where EstadosFactura_Facturas.IdentificadorEstado == 2
                                     where gerenteUusario.UsuarioId == novedadFactura.IdGerenteCargo
                                     where estadoAprobacionArea.EstadoFiscal == 2 
                                     where estadoAprobacionArea.EstadoHorasIT == 2
                                     where estadoAprobacionArea.EstadoHorasIFRS == 2
                                     where estadoAprobacionArea.EstadoHorasLegal == 2
                                     where estadoAprobacionArea.EstadosHorasImpuestos == 2





                                     select new FacturaAprobaciones()
                                     {

                                         //TotalLegal = novedadFactura.HorasLegales,

                                         //TotalIFRS = novedadFactura.HorasIFRS,
                                         //totalHoras = novedadFactura.TotalHoras,
                                         //totalSistema = novedadFactura.HorasSistemas,
                                         //totalImpuestos = novedadFactura.HorasImpuestos,
                                         estadoIt = estadoAprobacionArea.EstadoHorasIT,
                                         estadoImpuesto = estadoAprobacionArea.EstadosHorasImpuestos,
                                         estadoAuditoria = estadoAprobacionArea.EstadoFiscal,
                                         estadoIFRS = estadoAprobacionArea.EstadoHorasIFRS,
                                         estadoLegal = estadoAprobacionArea.EstadoHorasLegal,

                                         NombreCliente = cliente.RazonSocial,
                                         idFactura = novedadFactura.FacturaID,
                                         gerente = gerenteUusario.Nombre,
                                         fechaCreacion = novedadFactura.FechaDiligenciamiento


                                     }).ToList();






                return facturaAprobacion;

            };



        }

        public List<FacturaAprobaciones> FacturasAprobacionesContabilidad()
        {


            string usuario = SessionHelper.GetUser();


            Guid usarioAutenticado = Guid.Parse(usuario);
            var facturaAprobacion = new List<FacturaAprobaciones>();

            using (var ctx = new ModelContext())
            {


                //   facturaAprobacion = ctx.FacturaAprobacion.ToList();



                facturaAprobacion = (from estadoAprobacionArea in ctx.estadoAprobacionArea
                                     from novedadFactura in ctx.NovedadFactura
                                     from cliente in ctx.ClientePropuesta
                                     from EstadosFactura_Facturas in ctx.EstadosFactura_Factura
                                     from gerenteUusario in ctx.Usuarios
                                         //   from areas in ctx.AreasAprobacion
                                     where cliente.ClienteID == novedadFactura.IdCliente
                                     where novedadFactura.FacturaID == estadoAprobacionArea.IdFactura
                                     where EstadosFactura_Facturas.idFactura == novedadFactura.FacturaID
                                     where EstadosFactura_Facturas.IdentificadorEstado == 2
                                     where gerenteUusario.UsuarioId == novedadFactura.IdGerenteCargo
                                     where estadoAprobacionArea.EstadoFiscal == 2
                                     where estadoAprobacionArea.EstadoHorasIT == 2
                                     where estadoAprobacionArea.EstadoHorasIFRS == 2
                                     where estadoAprobacionArea.EstadoHorasLegal == 2
                                     where estadoAprobacionArea.EstadosHorasImpuestos == 2





                                     select new FacturaAprobaciones()
                                     {

                                         //TotalLegal = novedadFactura.HorasLegales,

                                         //TotalIFRS = novedadFactura.HorasIFRS,
                                         //totalHoras = novedadFactura.TotalHoras,
                                         //totalSistema = novedadFactura.HorasSistemas,
                                         //totalImpuestos = novedadFactura.HorasImpuestos,
                                         estadoIt = estadoAprobacionArea.EstadoHorasIT,
                                         estadoImpuesto = estadoAprobacionArea.EstadosHorasImpuestos,
                                         estadoAuditoria = estadoAprobacionArea.EstadoFiscal,
                                         estadoIFRS = estadoAprobacionArea.EstadoHorasIFRS,
                                         estadoLegal = estadoAprobacionArea.EstadoHorasLegal,

                                         NombreCliente = cliente.RazonSocial,
                                         idFactura = novedadFactura.FacturaID,
                                         gerente = gerenteUusario.Nombre,
                                         fechaCreacion = novedadFactura.FechaDiligenciamiento


                                     }).ToList();






                return facturaAprobacion;

            };



        }

        public string retornaAreaAporbacion() {


            string Rsult = "";
            AreasAprobacion areasAprobacion = new AreasAprobacion();

            using (var ctx = new ModelContext())
            {
                string usuario = SessionHelper.GetUser();

                Guid usarioAutenticado = Guid.Parse(usuario);

                areasAprobacion = ctx.AreasAprobacion.Where(x =>x.idUsuarioAprobacion == usarioAutenticado).SingleOrDefault();
                if (areasAprobacion != null) {


                    Rsult = areasAprobacion.AreaDescripcion;


                }

                return Rsult;

            }





            }

        }

 }

    