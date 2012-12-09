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
            ViewBag.Message = "";

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
 
            var contact = new EnvMail
            {
                From = envmail.From,
                Subject = envmail.Subject,
                Message = envmail.Message
            };
 
            new Email().Send(contact);
            return RedirectToAction("Index");
        }
     }
}
