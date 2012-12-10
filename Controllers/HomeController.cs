using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using Womyads.Models;

namespace Womyads.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ViewBag.Mensaje = "";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View(new EnvMail());
        }
        [HttpPost] 
        public ActionResult Contact(EnvMail envmail)
        {
         if (!ModelState.IsValid)
            {
                return View(envmail);
            }
 
            var datos = new EnvMail
            {
                Asunto = envmail.Asunto,
                Mensaje = envmail.Mensaje
            };
            
            new Email().Send(datos);
            return View(new EnvMail());
        }

     }
}
