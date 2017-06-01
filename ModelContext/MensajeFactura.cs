namespace ModelContext
{
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

    [Table("MensajeFactura")]
    public partial class MensajeFactura
    {
        [Key]
        [Column(Order = 0)]
        public Guid IdFactura { get; set; }

        public string MensajeUsuario { get; set; }

        public string MensajeSistema { get; set; }

        public DateTime fecha { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid idUsuario { get; set; }



        public string  obtenerMensajesFactura(Guid idFactura)
        {


            var listaNovedadFactura = new List<Mensaje>();



            using (var ctx = new ModelContext())
            {
                try
                {



                    var Rsulat = (from menFactu in ctx.MensajeFactura
                                  from usu in ctx.Usuarios
                                  where usu.UsuarioId == menFactu.idUsuario
                                  where menFactu.IdFactura == idFactura


                                  select new Mensaje()
                                  {

                                    fecha = menFactu.fecha,
                                    mensajeSistema = menFactu.MensajeSistema,
                                    mensajeUsuario = menFactu.MensajeUsuario,
                                    Usuario = usu.Nombre,





                                  }).OrderBy(x =>x.fecha).ToList();

                    string data = JsonConvert.SerializeObject(Rsulat, Formatting.Indented);

                    return data;
                }
                catch (Exception e)
                {

                    throw;
                }



            }

        }


    }
}
