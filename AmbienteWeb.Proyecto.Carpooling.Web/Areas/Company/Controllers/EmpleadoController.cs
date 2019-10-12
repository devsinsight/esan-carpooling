using AmbienteWeb.Proyecto.Carpooling.Web.Areas.Company.ViewModels;
using System.Web.Mvc;

namespace AmbienteWeb.Proyecto.Carpooling.Web.Areas.Company.Controllers
{
    [Authorize(Roles = "COMPANY")]
    public class EmpleadoController : Controller
    {
        
        public ActionResult RegistroEmpleados()
        {
            return View();
        }

        public ActionResult Empleado()
        {
            return PartialView(new EmpleadoViewModel());
        }

        public ActionResult EditarEmpleado(int id)
        {
            //TODO - Obtener Contacto
            var model = new EmpleadoViewModel
            {
                Id = id,
                Apellidos = "Perez",
                Nombres = "Juan",
                DNI = "66667777",
                Email = "juanperez@belatrixfx.com"
            };

            return PartialView("Empleado", model);
        }

        public ActionResult AgregarEmpleado(EmpleadoViewModel model)
        {
            //TODO - almacenar contacto
            if (model.Id.HasValue)
            {
                UpdateEmployee(model);
            }
            else
            {
                SaveEmployee(model);
            }

            return PartialView("ListaEmpleados");
        }

        private void UpdateEmployee(EmpleadoViewModel model)
        {

        }

        private void SaveEmployee(EmpleadoViewModel model)
        {

        }
    }
}