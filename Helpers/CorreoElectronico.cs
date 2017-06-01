using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Helpers
{
    public class CorreoElectronico
    {

        public void EnviarCorreoUsuario(string correo, string asunto, string cuerpo)
        {


            correo = "mdiego@amezquita.com";


            try
            {


                var mail = new MailMessage();
                mail.From = new MailAddress("servimp@amezquita.com.co", "Novedad Factura");
                mail.To.Add(correo);
                mail.Subject = asunto;
                mail.IsBodyHtml = true;
                mail.Body = cuerpo;

                var SmtpServer = new SmtpClient("smtp.gmail.com"); // or "smtp.gmail.com"
                SmtpServer.Port = 587;
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                SmtpServer.UseDefaultCredentials = false;

                // Agrega tu correo y tu contraseña, hemos usado el servidor de Outlook.
                SmtpServer.Credentials = new System.Net.NetworkCredential("servimp@amezquita.com.co", "Am3zqui74.2015*%");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch (Exception e)
            {

            }





        }


    }
}