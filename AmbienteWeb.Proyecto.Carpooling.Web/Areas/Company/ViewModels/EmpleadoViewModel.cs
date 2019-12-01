using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AmbienteWeb.Proyecto.Carpooling.Web.Areas.Company.ViewModels
{
    public class EmpleadoViewModel
    {
        public int? Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }

        [Required]
        public string DNI { get; set; }
        public string Email { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
    }
}