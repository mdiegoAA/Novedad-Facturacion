using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelContext;
namespace AmezquitaPropuestas.Controllers
{
    public class LoginController : Controller
    {
        private Usuarios usuario = new Usuarios();
        public ActionResult Login()
        {
            
            return View();
        }

        public JsonResult Acceder(string Email , string Password) {


            var rm = usuario.Login(Email , Password);

            if (rm.response) {

                rm.href = Url.Content("~/Home/Index");


            }

            return Json(rm);

        }



    }
}