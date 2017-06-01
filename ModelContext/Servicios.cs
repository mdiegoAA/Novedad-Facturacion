namespace ModelContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using Newtonsoft.Json;

    public partial class Servicios
    {
        [Key]
        public Guid ServicioId { get; set; }

        [StringLength(8)]
        public string Codigo { get; set; }

        public bool EsGenerico { get; set; }

        [StringLength(128)]
        public string NombreServicio { get; set; }



        public string listadoServicioJson()
        {

            try
            {


                var listadoServicios = new List<Servicios>();
                using (var ctx = new ModelContext())
                {


                    listadoServicios = ctx.Servicios.OrderBy(x => x.NombreServicio).ToList();
                    string data = JsonConvert.SerializeObject(listadoServicios, Formatting.Indented);
                    return data;
                };

           




            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<Servicios> listadoServicio() { 

            try
            {


                var listadoServicios = new List<Servicios>();
                using (var ctx = new ModelContext()) {


                    listadoServicios = ctx.Servicios.OrderBy(x => x.NombreServicio).ToList();

                };

                return listadoServicios;




            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
