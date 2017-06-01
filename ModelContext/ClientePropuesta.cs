namespace ModelContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using Newtonsoft.Json;
    

    [Table("ClientePropuesta")]
    public  class ClientePropuesta
    {
        [Key]
        public Guid ClienteID { get; set; }

        public string RazonSocial { get; set; }

        public string Nit { get; set; }

        public string Dv { get; set; }

        public string direccion { get; set; }

        public string TipoContribuyente { get; set; }

        public string Telefono { get; set; }

        [StringLength(100)]
        public string Celular { get; set; }

        public string ContactoCliente { get; set; }

        [StringLength(200)]
        public string Email { get; set; }


        public List<ClientePropuesta> ObtenerClientesPropuestas() {


            var clientesProuesta = new List<ClientePropuesta>();

            try
            {

                using (var ctx = new ModelContext())
                {


                    clientesProuesta = ctx.ClientePropuesta.OrderBy(x => x.RazonSocial).ToList();


                }




            }
            catch (Exception)
            {

                throw;
            }


            return clientesProuesta;


        }

        public string ObtenerClientesPropuestasJson()
        {


            var clientesProuesta = new List<ClientePropuesta>();

            try
            {

                using (var ctx = new ModelContext())
                {



                    var clienes = (from cliente in ctx.ClientePropuesta
                                   from ClientePropuesta in ctx.ClientePropuesta
                                   where cliente.Nit == ClientePropuesta.Nit

                                   select new ClientePropuesta
                                   {

                                       ClienteID = ClientePropuesta.ClienteID,
                                       RazonSocial = cliente.RazonSocial


                                   }).OrderBy(x => x.RazonSocial).ToList();

                    clientesProuesta = clienes;

                    string data = JsonConvert.SerializeObject(clientesProuesta, Formatting.Indented);
                    return data;

                }




            }
            catch (Exception)
            {

                throw;
            }


         


        }


        public string obtenerClienteId(string id) {


            var cliente = new ClientePropuesta();

            try
            {


                using (var ctx = new ModelContext())
                {

                    cliente = ctx.ClientePropuesta.Where(x => x.ClienteID.ToString() == id).FirstOrDefault();

                };

            }
            catch (Exception)
            {

                throw;
            }

            string data = JsonConvert.SerializeObject(cliente, Formatting.Indented);


            return data;
        }

    }
}
