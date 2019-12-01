using AmbienteWeb.Proyecto.Carpooling.BusinessLogic;
using AmbienteWeb.Proyecto.Carpooling.Web.Areas.Administrator.ViewModels;
using AmbienteWeb.Proyecto.Carpooling.Web.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using M = AmbienteWeb.Proyecto.Carpooling.DataAccess;

namespace AmbienteWeb.Proyecto.Carpooling.Web.Areas.Administrator.Controllers
{

    [Authorize(Roles = "ADMINISTRATOR")]
    public class ChoferController : Controller
    {

        private ChoferBusinessLogic _choferBusinessLogic;
        private ApplicationUserManager _userManager;
        public ChoferController()
        {
            _choferBusinessLogic = new ChoferBusinessLogic();
        }


        public ChoferController(ApplicationUserManager userManager)
        {
            _choferBusinessLogic = new ChoferBusinessLogic();
            UserManager = userManager;
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        private IEnumerable<ChoferViewModel> GetChoferes()
        {
            return _choferBusinessLogic.ObtenerTodos().Select(x => new ChoferViewModel
            {
                Nombres = x.Nombres,
                Apellidos = x.Apellidos,
                DNI = x.DNI,
                Email = x.Email,
                Telefono = x.Telefono,
                Id = x.Id,
                ModeloVehiculo = x.ModeloVehiculo,
                Placa = x.Placa
            });

        }

        public ActionResult RegistroChoferes()
        {
            ViewBag.ListaChoferes = GetChoferes();

            return View();
        }

        public ActionResult Chofer()
        {
            return PartialView(new ChoferViewModel());
        }

        public ActionResult EditarChofer(int id)
        {
            var chofer = _choferBusinessLogic.ObtenerChoferPorId(id);
            var model = new ChoferViewModel
            {
                Id = chofer.Id,
                Apellidos = chofer.Apellidos,
                Nombres = chofer.Nombres,
                Telefono = chofer.Telefono,
                DNI = chofer.DNI,
                Email = chofer.Email,
                Placa = chofer.Placa,
                ModeloVehiculo = chofer.ModeloVehiculo,
                IsEditMode = true
            };


            return PartialView("Chofer", model);
        }

        public async Task<ActionResult> AgregarChofer(ChoferViewModel model)
        {
            if (model.Id.HasValue)
            {
                await UpdateChofer(model);
            }
            else
            {
                await SaveChofer(model);
            }

            return PartialView("ListaChoferes", GetChoferes());
        }

        private async Task UpdateChofer(ChoferViewModel model)
        {
            var chofer = _choferBusinessLogic.ObtenerChoferPorId(model.Id);

            chofer.Nombres = model.Nombres;
            chofer.Apellidos = model.Apellidos;
            chofer.DNI = model.DNI;
            chofer.Telefono = model.Telefono;
            chofer.Placa = model.Placa;
            chofer.ModeloVehiculo = model.ModeloVehiculo;

            _choferBusinessLogic.ActualizarChofer(chofer);

            await UserManager.RemovePasswordAsync(chofer.UserId.ToString());
            await UserManager.AddPasswordAsync( chofer.UserId.ToString(), model.Password);
        }

        private async Task SaveChofer(ChoferViewModel model)
        {
            var user = new ApplicationUser { RazonSocial = "Org Company", RUC = "12345678910", UserName = model.Email, Email = model.Email };
            await UserManager.CreateAsync(user, model.Password);
            await UserManager.AddToRoleAsync(user.Id, "DRIVER");

            var chofer = new M.Chofer
            {
                Nombres = model.Nombres,
                Apellidos = model.Apellidos,
                UserId = new Guid(user.Id),
                DNI = model.DNI,
                Email = model.Email,
                Telefono = model.Telefono,
                Placa = model.Placa,
                ModeloVehiculo = model.ModeloVehiculo
            };

            _choferBusinessLogic.CrearChofer(chofer);

        }
    }
}