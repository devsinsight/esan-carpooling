using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmbienteWeb.Proyecto.Carpooling.Web.Areas.Chofer.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = "DRIVER")]
        public ActionResult Index()
        {
            return View();
        }
    }
}