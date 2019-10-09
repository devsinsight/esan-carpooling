using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmbienteWeb.Proyecto.Carpooling.Web.Areas.Administrator.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class HomeController : Controller
    {
        // GET: Administrator/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}