﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmbienteWeb.Proyecto.Carpooling.Web.Areas.Administrator.Controllers
{
    public class ConductorController : Controller
    {
        [Authorize(Roles = "ADMINISTRATOR")]
        public ActionResult Index()
        {
            return View();
        }
    }
}