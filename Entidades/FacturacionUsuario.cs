using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public  class FacturacionUsuario
    {

    
   public int estadoDirector { get; set; }


    public int estadeAsistenteGerencia { get; set; }

    public string nombreCliente { get; set; }
   
    public Guid FacturaId { get; set; }
    public string nombre {get;set;}

    public DateTime FechaDiligenciamiento { get; set; }

    public string Servicio { get; set; }

     public string HorasTI { get; set; }

        public string HorasAuditoria { get; set; }

        public string HorasOutsorcing { get; set; }

        public int estadoGerenciaGeneral { get; set; }

        public int? estadoContabilidadl { get; set; }



        public string HorasImpuestos { get; set; }

    public string HorasLegales { get; set; }

    public string TotalHoras { get; set; }

    public string Estado { get; set; }


    public string estadoHorasIT { get; set; }




        public string estadoHorasImpuesto { get; set; }

        public string estadoHorasLegal { get; set; }

        public string HorasTIEstado { get; set; }




    }
}
