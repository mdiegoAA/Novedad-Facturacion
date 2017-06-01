using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;
using AmezquitaPropuestas.App_Start;
using ModelContext;
using System.Web.Services;


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

using Helpers;
using Newtonsoft.Json;
using Entidades;




namespace AmezquitaPropuestas.Controllers
{
   
    public class HomeController : Controller
    {


        public static Guid auxGui;

        ControlFacturacion controlFacturacion = new ControlFacturacion();
        Usuarios usuarios = new Usuarios();
        ClientePropuesta clientesPropuesta = new ClientePropuesta();
        Servicios servicio = new Servicios();
          NovedadFactura novedadFacutra = new NovedadFactura();
        MensajeFactura mensajes = new MensajeFactura();
        // GET: Home


        public ActionResult Index() {


            string usuario =  SessionHelper.GetUser();
            usuario = usuario.ToUpper();
         //   Guid usarioAutenticado = Guid.Parse(usuario);

            ViewBag.IdUsuario = usuario;


            ViewBag.contabilidad = novedadFacutra.obtenerListadoNovedadFacturaXContabilidad();

            ViewBag.aprobacionGerenteGeneral = novedadFacutra.obtenerListadoNovedadFacturaXGerenteGeneral();
            ViewBag.AsistenteGeneral = novedadFacutra.obtenerListadoNovedadFacturaXAsistenteGerenteGeneral();

            ViewBag.AreaEspecializada = novedadFacutra.obtenerListadoNovedadFacturaAreaEspecializada();

            ViewBag.Gerente = novedadFacutra.obtenerListadoNovedadFacturaXGerente();


            ViewBag.aprobacionDirector = novedadFacutra.obtenerListadoNovedadFacturaXDirector();
            ViewBag.nombre = usuarios.NombreObtenerUsuario();
            ViewBag.AreaAprobacion = novedadFacutra.retornaAreaAporbacion();

            if (ViewBag.AreaAprobacion == "AprobacionAuxiliarGerencia")
            {
                ViewBag.Aprobacion = FacturasAprobacionesAuxGerencia();

            }
            else {

                ViewBag.Aprobacion = FacturasAprobaciones();

            }

          
          
            return View(novedadFacutra.obtenerListadoNovedadFactura());

        }


        public ActionResult EditarFactura(Guid idFactura) {

            ViewBag.nombre = usuarios.NombreObtenerUsuario();
            ViewBag.listadoDirectors = usuarios.listadoDirectores();
            ViewBag.listadoGerentes = usuarios.listadoGerentes();
            ViewBag.listadClientes = obtenerListadoClientes();
            ViewBag.listadoServicios = servicio.listadoServicio();

            return View(novedadFacutra.obtenerNovedadFactura(idFactura));

        }
      

        public ActionResult ExportaPdf(Guid idFactura) {
            return new Rotativa.ActionAsPdf("pdf", new { json = idFactura });
        }


        public ActionResult AgregarNovedadFactura() {

            ViewBag.nombre = usuarios.NombreObtenerUsuario();
            ViewBag.listadoDirectors = usuarios.listadoDirectores();
            ViewBag.listadoGerentes = usuarios.listadoGerentes();
            ViewBag.listadClientes = obtenerListadoClientes();
            ViewBag.listadoServicios = servicio.listadoServicio();

            return View();

        }

        public ActionResult PDF(Guid json) {

         //   string Rsult = FrontOfficeStartUp.facturaId();
            return View(
                novedadFacutra.obtenerNovedadFacturaPdf(json)
            );

        }

        [WebMethod]
        public   string obtenerCliente(string id) {

            try
            {
                string rSult = clientesPropuesta.obtenerClienteId(id);

                return rSult;


            }
            catch (Exception)
            {

                throw;
            }


       

        }



        public List<ClientePropuesta> obtenerListadoClientes() {

            return clientesPropuesta.ObtenerClientesPropuestas();


        }


        public string obtenerListadoGerentesJson()
        {

            return usuarios.listadoGerentesJson();


        }


        public string obtenerListadoDirectorJson()
        {

            return usuarios.listadoDirectorJson();


        }

        public string obtenerListadoClientesJson()
        {

            return clientesPropuesta.ObtenerClientesPropuestasJson();


        }

        public string obtenerListadoServiciosJson()
        {

            return servicio.listadoServicioJson();


        }


        public JsonResult GuardarControlFactura(ControlFacturacion controlFacturacion){

            controlFacturacion.guardarControlFactura();
            var rm = new ResponseModel();
            return Json(rm);
        }
        public JsonResult EditarFacturass(NovedadFactura NOVEDAD, string mensaje)
        {

            //  string usuarioId = FrontOfficeStartUp.UsuarioVisualizando();

            var rm = new ResponseModel();
          //  Guid idFactura = Guid.NewGuid();
          //  NOVEDAD.FacturaID = idFactura;
            NOVEDAD.EditarNovedadFacturasM(mensaje);
            rm.href = Url.Content("~/Home/Index");

            return Json(rm);



        }
        public JsonResult guardarfACTURA(NovedadFactura NOVEDAD , string mensaje) {

            //  string usuarioId = FrontOfficeStartUp.UsuarioVisualizando();

            var rm = new ResponseModel();
            Guid idFactura = Guid.NewGuid();
            NOVEDAD.FacturaID = idFactura;
            NOVEDAD.guardarNovedadFactura(mensaje);
            rm.href = Url.Content("~/Home/Index");

            return Json(rm);



        }
        public JsonResult EditarNombreContato( string nombreContato , Guid idCliente)
        {

            //  string usuarioId = FrontOfficeStartUp.UsuarioVisualizando();


            novedadFacutra.EditarNombreCOntato(idCliente , nombreContato);
            var rm = new ResponseModel();
           
            

            return Json(rm);



        }
        public JsonResult EditarCelularContato(string celularContato, Guid idCliente)
        {

            //  string usuarioId = FrontOfficeStartUp.UsuarioVisualizando();


            novedadFacutra.EditarCelularContato(idCliente, celularContato);
            var rm = new ResponseModel();



            return Json(rm);



        }
        public JsonResult EditarEmailContato(string email, Guid idCliente)
        {

            //  string usuarioId = FrontOfficeStartUp.UsuarioVisualizando();


            novedadFacutra.EditarEmailContato(idCliente, email);
            var rm = new ResponseModel();



            return Json(rm);



        }
        public JsonResult EditarDireccionContato(string direccion, Guid idCliente)
        {

            //  string usuarioId = FrontOfficeStartUp.UsuarioVisualizando();


            novedadFacutra.EditarDireccionContato(idCliente, direccion);
            var rm = new ResponseModel();



            return Json(rm);



        }

        public JsonResult EditarTelefonoContato(string Telefono, Guid idCliente)
        {

            //  string usuarioId = FrontOfficeStartUp.UsuarioVisualizando();


            novedadFacutra.EditarTelefonoContato(idCliente, Telefono);
            var rm = new ResponseModel();



            return Json(rm);



        }

        [WebMethod]
        public string obtenerMensajes(Guid idFactur) {

         string rSult =   mensajes.obtenerMensajesFactura(idFactur);

            return rSult;


        }


        public void EliminarFactura(Guid idFactura)
        {

            try
            {
               novedadFacutra.EliminarFactura((idFactura));


               
            }
            catch (Exception)
            {

                throw;
            }


        }


        //  [HttpPost]
        public ActionResult obtenerFactura(Guid idFactura )
        {

            ViewBag.nombre = usuarios.NombreObtenerUsuario();
            ViewBag.listadoDirectors = usuarios.listadoDirectores();
            ViewBag.listadoGerentes = usuarios.listadoGerentes();
            ViewBag.listadClientes = obtenerListadoClientes();
            ViewBag.listadoServicios = servicio.listadoServicio();

            return View(novedadFacutra.obtenerNovedadFactura(idFactura));


        }

           [WebMethod]
    
        public  string actualizarEstado(Guid idFactura , string mensaje) {

            try
            {
                string d = novedadFacutra.actualizarEstado((idFactura), mensaje);


                return d;
            }
            catch (Exception)
            {

                throw;
            }

       
        }



        public string AprobacionDirector(Guid idFactura, string mensaje)
        {

            try
            {
                string d = novedadFacutra.AprobarDirector((idFactura), mensaje);


                return d;
            }
            catch (Exception)
            {

                throw;
            }


        }


        public string AprobacionContabilidad(Guid idFactura, string mensaje)
        {
            string email = novedadFacutra.obtenerCorreoDirectorCreador(idFactura);
            try
            {
                string d = novedadFacutra.AprobarContabilidad((idFactura), mensaje , email );


                return d;
            }
            catch (Exception)
            {

                throw;
            }


        }


        public string AprobacionRechazarFactura(Guid idFactura, string mensaje, string cargo)
        {

            try
            {

                string nombreLogeado = usuarios.NombreObtenerUsuario();
                string correoCreador = novedadFacutra.obtenerCorreoUsuarioCreador(idFactura);

                string d = novedadFacutra.RechazarFactura((idFactura), mensaje, cargo, nombreLogeado, correoCreador);


                return d;
            }
            catch (Exception)
            {

                throw;
            }


        }


        public string AprobacionGerenteGeneral(Guid idFactura, string mensaje)
        {

            try
            {
                string d = novedadFacutra.AprobarGerenteGeneral((idFactura), mensaje);


                return d;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public string AprobacionAsistenteGerenteGeneral(Guid idFactura, string mensaje)
        {

            try
            {
                string d = novedadFacutra.AprobarAsistenteGerenteGeneral((idFactura), mensaje);


                return d;
            }
            catch (Exception)
            {

                throw;
            }


        }



        public List<FacturaAprobaciones> FacturasAprobacionesAuxGerencia()
        {

            return novedadFacutra.FacturasAprobacionesAuxliarGerencia();

        }

     


        public List<FacturaAprobaciones> FacturasAprobaciones() {

            return novedadFacutra.FacturasAprobaciones();

        }


        public string ListadoControlFacturacion(Guid idFactura)
        {


            string result =  JsonConvert.SerializeObject(controlFacturacion.listadoControlFacturacion(idFactura), Formatting.Indented);

            return result;

        }


        public void aprobarArea(Guid idFactura, string mensaje , int area ){

       

            novedadFacutra.AprobacionArea(idFactura, mensaje, area);

            }

        public void ModificarTiempo(string HorasTiEditar , string TotalHorasEditar , string HorasServicioEditar , string HorasLegalesEditar , string HorasIMPUESTOSEditar , string HorasifrsEditar , string idfactura) {

            novedadFacutra.ModificarTiempo(HorasTiEditar, TotalHorasEditar, HorasServicioEditar, HorasLegalesEditar, HorasIMPUESTOSEditar, HorasifrsEditar, idfactura);

        }
        public void RechazarArea(Guid idFactura, string mensaje, int area)
        {



            novedadFacutra.EliminarArea(idFactura, mensaje, area);

        }

        public void ActualizarTiemporArea(Guid idFactura, string mensaje, int area , int Tiempo)
        {



            novedadFacutra.ActualizarTiemporArea(idFactura, mensaje, area , Tiempo);

        }



    }
}