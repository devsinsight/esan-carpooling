using AmbienteWeb.Proyecto.Carpooling.BusinessLogic;
using AmbienteWeb.Proyecto.Carpooling.DataAccess;
using AmbienteWeb.Proyecto.Carpooling.Web.Areas.Company.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web.Mvc;

namespace AmbienteWeb.Proyecto.Carpooling.Web.Areas.Company.Controllers
{
    [Authorize(Roles = "COMPANY")]
    public class EmpleadoController : Controller
    {

        private EmpleadoBusinessLogic _empleadoBusinessLogic;
        private EmpresaBusinessLogic _empresaBusinessLogic;

        public EmpleadoController() {
            _empleadoBusinessLogic = new EmpleadoBusinessLogic();
            _empresaBusinessLogic = new EmpresaBusinessLogic();
        }

        private int GetEmpresaId() {
            var identity = (ClaimsIdentity)User.Identity;
            Claim claim = identity.Claims.First(x => x.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");
            var empresa = _empresaBusinessLogic.ObtenerEmpresaPorUserId(claim.Value);
            return empresa.Id;
        }

        private IEnumerable<EmpleadoViewModel> GetEmpleados() {

            return _empleadoBusinessLogic.ObtenerTodos(GetEmpresaId()).Select(x => new EmpleadoViewModel
            {
                Nombres = x.Nombres,
                Apellidos = x.Apellidos,
                DNI = x.DNI,
                Email = x.Email,
                Telefono = x.Telefono,
                Id = x.Id
            });
        
        }

        public ActionResult RegistroEmpleados()
        {
            ViewBag.ListaEmpleados = GetEmpleados();
            return View();
        }

        public ActionResult Empleado()
        {
            return PartialView(new EmpleadoViewModel());
        }

        public ActionResult EditarEmpleado(int id)
        {
            var empleado = _empleadoBusinessLogic.ObtenerEmpleadoPorId(id);
            var model = new EmpleadoViewModel
            {
                Id = empleado.Id,
                Apellidos = empleado.Apellidos,
                Nombres = empleado.Nombres,
                Telefono = empleado.Telefono,
                DNI = empleado.DNI,
                Email = empleado.Email
            };


            return PartialView("Empleado", model);
        }

        [HttpPost]
        public ActionResult EditarMapaEmpleado(int id)
        {
            var empleado = _empleadoBusinessLogic.ObtenerEmpleadoPorId(id);
            var model = new EmpleadoViewModel
            {
                Id = empleado.Id,
                Apellidos = empleado.Apellidos,
                Nombres = empleado.Nombres,
                Telefono = empleado.Telefono,
                DNI = empleado.DNI,
                Email = empleado.Email,
                Latitude = empleado.Latitude,
                Longitude = empleado.Longitude
            };

            return PartialView("MapaEmpleado", model);
        }

        [HttpPost]
        public ActionResult GrabarMapaEmpleado(EmpleadoViewModel model)
        {
            var empleado = _empleadoBusinessLogic.ObtenerEmpleadoPorId(model.Id);
            empleado.Latitude = model.Latitude;
            empleado.Longitude = model.Longitude;

            _empleadoBusinessLogic.ActualizarEmpleado(empleado);

            return PartialView("ListaEmpleados", GetEmpleados());
        }


        public ActionResult AgregarEmpleado(EmpleadoViewModel model)
        {
            if (model.Id.HasValue)
            {
                UpdateEmployee(model);
            }
            else
            {
                SaveEmployee(model);
            }

            return PartialView("ListaEmpleados", GetEmpleados());
        }

        private void UpdateEmployee(EmpleadoViewModel model)
        {
            var empleado = _empleadoBusinessLogic.ObtenerEmpleadoPorId(model.Id);

            empleado.Nombres = model.Nombres;
            empleado.Apellidos = model.Apellidos;
            empleado.DNI = model.DNI;
            empleado.Email = model.Email;
            empleado.Telefono = model.Telefono;
           
            _empleadoBusinessLogic.ActualizarEmpleado(empleado);
        }

        private void SaveEmployee(EmpleadoViewModel model)
        {
            var empleado = new Empleado
            {
                EmpresaId = GetEmpresaId(),
                Nombres = model.Nombres,
                Apellidos = model.Apellidos,
                DNI = model.DNI,
                Email = model.Email,
                Telefono = model.Telefono
            };

            _empleadoBusinessLogic.CrearEmpleado(empleado);

        }
    }
}