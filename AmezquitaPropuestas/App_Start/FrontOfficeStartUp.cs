using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmezquitaPropuestas.App_Start
{
    public class FrontOfficeStartUp
    {

        public static string UsuarioVisualizando()
        {
            string usuario_id_por_defecto = "";
            string usuario_id = HttpContext.Current.Request.QueryString["id"];

            return usuario_id != null ? (usuario_id) : usuario_id_por_defecto;
        }

        public static string facturaId()
        {
            string usuario_id_por_defecto = "";
            string usuario_id = HttpContext.Current.Request.QueryString["idFactura"];

            return usuario_id;
        }


    }
}