using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AmbienteWeb.Proyecto.Carpooling.Web.Areas.Administrator.ViewModels
{
    public class ChoferViewModel
    {
        public int? Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }

        [Required]
        public string DNI { get; set; }
        public string Email { get; set; }

        public string Placa { get; set; }
        public string ModeloVehiculo { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}