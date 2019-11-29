
using AmbienteWeb.Proyecto.Carpooling.Web.Areas.Company.ViewModels;
using System.Web.Mvc;

namespace AmbienteWeb.Proyecto.Carpooling.Web.Areas.Company.Controllers
{
    [Authorize(Roles = "COMPANY")]
    public class EmpresaController : Controller
    {
        // GET: Administrator/Empresa
        public ActionResult EditarEmpresa()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditarEmpresa(EmpresaViewModel empresa)
        {
            return View();
        }


    }
}