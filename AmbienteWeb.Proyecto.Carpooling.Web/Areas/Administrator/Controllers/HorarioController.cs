using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmbienteWeb.Proyecto.Carpooling.Web.Areas.Administrator.Controllers
{

    [Authorize(Roles = "ADMINISTRATOR")]
    public class HorarioController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
    }
}