namespace ModelContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Data.SqlClient;
    using System.Linq;

    [Table("ControlFacturacion")]
    public partial class ControlFacturacion
    {
        [Key]
        [Column(Order = 0)]
        public Guid idFacturaNovedad { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string periodo { get; set; }

        [StringLength(100)]
        public string NumeroFactura { get; set; }

        public string obesrvaciones { get; set; }

        [StringLength(100)]
        public string ValorFacturado { get; set; }

        public void guardarControlFactura()
        {
            var rm = new ResponseModel();

            try
            {


                using (var ctx = new ModelContext())
                {


                    ctx.Entry(this).State = System.Data.Entity.EntityState.Added;
                    ctx.SaveChanges();


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

        public List<ControlFacturacion> listadoControlFacturacion(Guid idFactura)
        {

            List<ControlFacturacion> listadoControlFacturacionResult = new List<ControlFacturacion>();

            using (var ctx = new ModelContext())
            {
                try
                {
                    return ctx.Database.SqlQuery<ControlFacturacion>("sp_ObtenerListadoControlFacturacion @idFactura", new SqlParameter("idFactura", idFactura)).ToList();
                 
                }
                catch
                {
                    throw;
                }
            }



            return listadoControlFacturacionResult;

        }
    }

}
