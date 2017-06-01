using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public  class Factura
    {
        public Guid facturaId { get; set; }
        public int FacturaConcutivo { get; set; }
        public DateTime FechaDiligenciamiento { get; set; }

        public string ConsecutivoControlTiempo { get; set; }

        public string RazonSocial { get; set; }

        public string Nit { get; set; }

        public string Dv { get; set; } 

        public string Direccion { get; set; }

        public string TipoContribuyente { get; set; }

        public string Telefono { get; set; }

        public string celular { get; set; }

        public string ContactoCliente { get; set; }

        public string Email { get; set; }

        public Guid IdCliente { get; set; }

        public string nombreCliente { get; set; }


        public Guid TipoServicio { get; set; }

      
        public string Sector { get; set; }

     
        public string Antiguedad { get; set; }

   
        public string numeroContrato { get; set; }

     
        public string ValorAnualSinIva { get; set; }

    
        public string MesesCuotasEjecucion { get; set; }

    
        public string ManejoCuotaInicial { get; set; }

     
        public string PorcentajeCuotaInicial { get; set; }

      
        public string ValorCuotaInicial { get; set; }

     
        public string ValorCoutasMensuales { get; set; }

    
        public string ValorMensualSinIva { get; set; }

    
        public string Gravado { get; set; }

      
        public string ValorTotalContratoIncluidoIvaAnual { get; set; }

      
        public DateTime FechaInicioContrato { get; set; }

       
        public DateTime FechaFinalizacionContrato { get; set; }

     
        public DateTime FechaInicioFacturacion { get; set; }

    
        public string FacturacionMensual { get; set; }

     
        public string FechaEntregaFacturacion { get; set; }

     
        public string CondicionIniciarFacturacion { get; set; }

        public string TextoFacturacionObservaciones { get; set; }

        
        public string razonSocialCorto { get; set; }


        public int HorasImpuestos { get; set; }

     
        public int HorasLegales { get; set; }

        public string nombreServicio { get; set; }
       
        public int HorasSistemas { get; set; }

        public string nombreGerente { get; set; }

        public string nombreDirector { get; set; }
       
        public int HorasIFRS { get; set; }

      
        public int HorasAuditoria { get; set; }

      
        public int TotalHoras { get; set; }

      

        public Guid IdGerenteCargo { get; set; }

     
        public Guid IdDirectorCargo { get; set; }

     
        public string ventaCargo1 { get; set; }

      
        public string ProcentajeventaCargo1 { get; set; }

     
        public string ventaCargo2 { get; set; }

     
        public string ProcentajeventaCargo2 { get; set; }

      
        public string ventaCargo3 { get; set; }

       
        public string ProcentajeventaCargo3 { get; set; }

        public string año { get; set; }

        public string añoProx { get; set; }

        public string asistenteAuditoria { get; set; }

        public string asistenteAuditoriaProx { get; set; }

        public string auditorJunior { get; set; }

        public string supervisoJunior { get; set; }

        public string supervisoJuniorProx { get; set; }

        public string supervisoSemi { get; set; }

        public string supervisoSemiProx { get; set; }

        public string supervisoSenior { get; set; }

        public string supervisoSeniorProx { get; set; }

        public string gerenteJunior { get; set; }

        public string gerenteJuniorAprox { get; set; }

        public string gerenteSemi{ get; set; }

        public string gerenteSemirAprox { get; set; }

        public string gerenteSenior { get; set; }

        public string gerenteSeniorAprox { get; set; }



        public string directorJunior { get; set; }

        public string directorJuniorAprox { get; set; }

        public string  directorSemi { get; set; }

        public string directorSemirAprox { get; set; }

        public string directorSenior { get; set; }

        public string directorSeniorAprox { get; set; }


        public string totalHorasAuditoria { get; set; }

        public string totalHorasAuditoriaProx{ get; set; }



        public string auditorJuniorProx { get; set; }

        public string auditorSemisenior { get; set; }

        public string auditorSemiseniorProx { get; set; }

        public string auditorSenior { get; set; }

        public string auditorSeniorProx { get; set; }

        public string auditorTI { get; set; }

        public string auditoraTIProx { get; set; }

        public string SupervisorTI { get; set; }
        public string SupervisorTIProx { get; set; }

        public string GerenteTI { get; set; }

        public string GerenteTIProx { get; set; }

        public string AuditorImpuesto { get; set; }

        public string AuditorImpuestoProx { get; set; }

        public string GerenteImpuesto { get; set; }

        public string GerenteImpuestoProx { get; set; }





        public string AsesorJuridico { get; set; }

        public string AsesorJuridicoProx { get; set; }

        public string GerenteJuridicio { get; set; }

        public string GerenteJuridicioProx { get; set; }

        public string totalHorasEsepcializadas { get; set; }

        public string totalHorasEsepcializadasProx { get; set; }

        public string Total { get; set; }

        public string TotalAprox { get; set; }

        public Guid ServicioId { get; set; }


        public string GreneteOut { get; set; }

        public string GreneteOutProx { get; set; }

        public string supervisorOut { get; set; }

        public string supervisorOutProx { get; set; }

        public string CoordinadorOut { get; set; }

        public string CoordinadorOutProx { get; set; }

        public string AnalistaOut { get; set; }

        public string AnalistaOudProx { get; set; }

        public string AuxiliarOut { get; set; }

        public string AuxiliarOutProx { get; set; }


        public string rsultOut { get; set; }

        public string rsultOutProx { get; set; }

      






    }
}
