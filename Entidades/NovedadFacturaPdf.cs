using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public  class NovedadFacturaPdf
    {

        public DateTime fechaDiligenciamiento { get; set; }

        public string consecutivoControlTiempos { get;set;}

        public string RazonSocial { get; set; }

        public string Nit { get; set; }

        public string DV { get; set; }

        public string Direccion { get; set; }

        public string TipoContribuyente { get; set; }

        public string Telefono { get; set; }

        public string Celular { get; set; }
        public string ContactoCliente { get; set; }

        public string Email { get; set; }

        public string nombreServicio { get; set; }

        public string Sector { get; set; }

        public string Cliente { get; set; }

        public string numeroContacto { get; set; }

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

        public string FechaEntregaFacturacion { get; set; }

        public string FacturacionMensual { get; set; }

        public string CondicionIniciarFacturacion { get; set; }

        public string TextoFacturacionObservaciones { get; set; }

        public int HorasImpuestos { get; set; }

        public int HorasLegales { get; set; }

        public int HorasSistemas { get; set; }

        public int HorasIFRS { get; set; }

        public int HorasAuditoria { get; set; }

        public int TotalHoras { get; set; }

        public string nombreGerente { get; set; }

        public string nombreDirector { get; set; }



    }
}
