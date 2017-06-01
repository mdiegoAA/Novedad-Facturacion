namespace ModelContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using Helpers;
    using Newtonsoft.Json;
    using Entidades;
    using System.DirectoryServices;
    public partial class Usuarios
    {
        [Key]
        public Guid UsuarioId { get; set; }

        [StringLength(64)]
        public string NombreUsuario { get; set; }

        [StringLength(256)]
        public string Nombre { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        public bool EmailConfirmado { get; set; }

        public int AccesosFallidos { get; set; }

        public bool Bloqueado { get; set; }

        public DateTime? FechaBloqueo { get; set; }

        public Guid CargoId { get; set; }

        public string Cedula { get; set; }

        public virtual Cargos Cargos { get; set; }



        public string NombreObtenerUsuario() {

            string usuario = SessionHelper.GetUser();
            Guid usarioAutenticado = Guid.Parse(usuario);

            var usuarios = new Usuarios();

            try
            {

                using (var ctx = new ModelContext())
                {

                    usuarios = (ctx.Usuarios.Where(x => x.UsuarioId == usarioAutenticado)
                     .SingleOrDefault());
                }

                string usuarioNombre = usuarios.Nombre.ToString();
                return usuarioNombre;


            }
            catch (Exception e)
            {

                throw;
            }




        }



        public ResponseModel Login(string usuario, string pass)
        {

            var rm = new ResponseModel();

            var usuarios = new Usuarios();

            try
            {

                using (var ctx = new ModelContext())
                {

                    usuarios = (ctx.Usuarios.Where(x => x.NombreUsuario == usuario)
                                                          .SingleOrDefault());
                }



            }
            catch (Exception e)
            {

                throw;
            }


            if (usuarios != null)
            {



                //   bool acutenticacion = AutenticacionUsuario(usuario, pass);



                SessionHelper.AddUserToSession(usuarios.UsuarioId.ToString());
                rm.SetResponse(true);


            }
            else
            {
                rm.SetResponse(false, "Correo o contraseña incorrecta");
            }

            return rm;


        }








        //public ResponseModel Login(string usuario, string pass)
        //{

        //    var rm = new ResponseModel();

        //    var usuarios = new Usuarios();

        //    try
        //    {

        //        using (var ctx = new ModelContext())
        //        {

        //            usuarios = (ctx.Usuarios.Where(x => x.NombreUsuario == usuario)
        //                                                  .SingleOrDefault());
        //        }



        //    }
        //    catch (Exception e)
        //    {

        //        throw;
        //    }


        //    if (usuarios != null)
        //    {



        //        bool acutenticacion = AutenticacionUsuario(usuario, pass);

        //        if (acutenticacion == true)
        //        {

        //            SessionHelper.AddUserToSession(usuarios.UsuarioId.ToString());
        //            rm.SetResponse(true);


        //        }
        //        else
        //        {
        //            rm.SetResponse(false, "Correo o contraseña incorrecta");
        //        }



        //    }
        //    else
        //    {
        //        rm.SetResponse(false, "Correo o contraseña incorrecta");
        //    }

        //    return rm;


        //}



        public bool AutenticacionUsuario(string userInfo, string pass)
        {

            string path = @"LDAP://10.0.0.2";
            string dominio = @"aa.amezquita.com.co";
            string domUsu = dominio + @"\" + userInfo;

            bool autenticacion = AutenticacionUsuarioDirectorioActivo(path, domUsu, pass);

            if (autenticacion)
            {
                return true;

            }
            else
            {

                return false;
            }


        }

        private bool AutenticacionUsuarioDirectorioActivo(string path, string user, string pass)
        {

            DirectoryEntry de = new DirectoryEntry(path, user, pass, AuthenticationTypes.Secure);
            try
            {
                DirectorySearcher ds = new DirectorySearcher(de);
                ds.FindOne();

                return true;
            }
            catch (Exception e)
            {
                return false;
               
            }

        }


        public List<Usuarios> listadoDirectores() {


            var Listausuarios = new List<Usuarios>();

            try
            {

                using (var ctx = new ModelContext())
                {

                    Listausuarios = (ctx.Usuarios.Include("Cargos").Where(x => x.Cargos.NombreCargo.Contains("DIRECTOR")).ToList());

                }

                return Listausuarios;

            }
            catch (Exception e)
            {

                throw;
            }


          



        }

        public List<Usuarios> listadoGerentes()
        {


            var Listausuarios = new List<Usuarios>();

            try
            {

                using (var ctx = new ModelContext())
                {

                    Listausuarios = (ctx.Usuarios.Include("Cargos").Where(x => x.Cargos.NombreCargo.Contains("GERENTE")).ToList());

                }

                return Listausuarios;

            }
            catch (Exception e)
            {

                throw;
            }






        }

        public string listadoGerentesJson()
        {


            var Listausuarios = new List<Usuarios>();

            try
            {

                using (var ctx = new ModelContext())
                {

                 


                        var obtenerUsuario = (from usuario in ctx.Usuarios
                                              from cargo in ctx.Cargos
                                              where usuario.CargoId == cargo.CargoId
                                              where cargo.NombreCargo.Contains("GERENTE")

                                              select new Entidades.UsuariosEntidades()
                                              {
                                                  usuarioId = usuario.UsuarioId,
                                                  nombreUsuario = usuario.Nombre


                                              }).ToList();



                                      //        Listausuarios = (ctx.Usuarios.Include("Cargos").Where(x => x.Cargos.NombreCargo.Contains("GERENTE")).ToList());
                    string data = JsonConvert.SerializeObject(obtenerUsuario, Formatting.Indented);
                    return data;
                }

              

            }
            catch (Exception e)
            {

                throw;
            }






        }

        public string listadoDirectorJson()
        {


            var Listausuarios = new List<Usuarios>();

            try
            {

                using (var ctx = new ModelContext())
                {




                    var obtenerUsuario = (from usuario in ctx.Usuarios
                                          from cargo in ctx.Cargos
                                          where usuario.CargoId == cargo.CargoId
                                          where cargo.NombreCargo.Contains("DIRECTOR")

                                          select new Entidades.UsuariosEntidades()
                                          {
                                              usuarioId = usuario.UsuarioId,
                                              nombreUsuario = usuario.Nombre


                                          }).ToList();



                    //        Listausuarios = (ctx.Usuarios.Include("Cargos").Where(x => x.Cargos.NombreCargo.Contains("GERENTE")).ToList());
                    string data = JsonConvert.SerializeObject(obtenerUsuario, Formatting.Indented);
                    return data;
                }



            }
            catch (Exception e)
            {

                throw;
            }






        }







    }
}
