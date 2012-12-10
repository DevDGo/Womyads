using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using System.Configuration;
using System.Net.Mail;
using System.Net; 
using Womyads.Models;


namespace Womyads.Models
{
    public class EnvMail
    {
        [Required]
        public string Asunto { get; set; }

        [Required]
        public string Mensaje { get; set; }
    }
     public class Email
    {
         public void Send(EnvMail datos)
         {

             var desde = new MailAddress("alejandrorodriguezperalta@gmail.com", "Diego Rodriguez");
             var destino = new MailAddress("alejandrorodriguezperalta@gmail.com", "Diego Rodriguez");
             const string fromPassword = "dianita0318";

             var smtp = new SmtpClient
             {
                 Host = "smtp.gmail.com",
                 Port = 587,
                 EnableSsl = true,
                 DeliveryMethod = SmtpDeliveryMethod.Network,
                 UseDefaultCredentials = false,
                 Credentials = new NetworkCredential(desde.Address, fromPassword)
             };

                 MailMessage correo = new MailMessage(desde, destino);
                 correo.Subject = datos.Asunto;
                 correo.Body = datos.Mensaje;
                 smtp.Send(correo);

         }
        
    }
}
    
