using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
 public class FacturaAprobaciones
    {
        public string gerente { get; set; }
        public int TotalLegal { get; set; }
        public int TotalIFRS { get; set; }

        public   int totalHoras { get; set;}

        public DateTime fechaCreacion { get; set; }
        public int totalSistema { get; set; }

        public int totalImpuestos { get; set; }

        public int estadoIt { get; set; }

        public int estadoIFRS { get; set; }

        public int estadoAuditoria { get; set; }

        public int estadoLegal { get; set; }

        public int estadoImpuesto { get; set; }

        public  string Estado { get; set; }

        public string NombreArea { get; set;}

        public string NombreCliente { get; set; }


        public string usuarioAprobacion { get; set; }

        public Guid idFactura { get; set; }




    }
}
