using AmbienteWeb.Proyecto.Carpooling.Web.Areas.Administrator.ViewModels;
using System.Web.Mvc;

namespace AmbienteWeb.Proyecto.Carpooling.Web.Areas.Administrator.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: Administrator/Empresa
        public ActionResult RegistroEmpresas()
        {
            return View();
        }

        #region Contacto

        public ActionResult RegistroContactos(){
            return View();
        }

        public ActionResult Contacto() {
            return PartialView(new ContactoViewModel());
        }

        public ActionResult EditarContacto(int id)
        {
            //TODO - Obtener Contacto
            var model = new ContactoViewModel
            {
                Id = id,
                Apellidos = "Perez",
                Nombres = "Juan",
                DNI = "66667777",
                Email = "juanperez@belatrixfx.com"
            };

            return PartialView("Contacto", model);
        }

        public ActionResult AgregarContacto(ContactoViewModel model) {
            //TODO - almacenar contacto
            if (model.Id.HasValue) {
                UpdateContact(model);
            }
            else {
                SaveContact(model);
            }

            return PartialView("ListaContactos");
        }

        private void UpdateContact(ContactoViewModel model) { 
        
        }

        private void SaveContact(ContactoViewModel model) { 
            
        }


        #endregion
    }
}