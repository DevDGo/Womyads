using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCDashboard.Controllers
{
    public class DashboardController : Controller
    {
        //
        // GET: /Dashboard/

        public ActionResult Index()
        {
            return View();
        }

        #region Json
        public JsonResult GetPieChartData()
        {

            var data = new[] { new { Name = "Smart Phone", Value = 25000 }, 
                                new { Name = "TV/LCD", Value = 5418 },
                                new { Name = "Desktop PC", Value = 8457 },
                                new { Name = "Laptop", Value = 12457 },
                                new { Name = "Appliance", Value = 874 },};

            return Json(data);
        }
        #endregion 

        #region Child-Only

        [ChildActionOnly]
        [OutputCache(Duration = 1, VaryByParam = "None")]
        public ActionResult DashboardItem_Users()
        {
            return View();
        }
        [ChildActionOnly]
        [OutputCache(Duration = 1, VaryByParam = "None")]
        public ActionResult DashboardItem_Orders()
        {

            return View();
        }

        [ChildActionOnly]
        [OutputCache(Duration = 1, VaryByParam = "None")]
        public ActionResult DashboardItem_SalesPie()
        {


            return View();
        }
        [ChildActionOnly]
        [OutputCache(Duration = 1, VaryByParam = "None")]
        public ActionResult DashboardItem_Visitors()
        {


            return View();
        }
        #endregion
    }
}
