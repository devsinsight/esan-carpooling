using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmbienteWeb.Proyecto.Carpooling.Web.Models
{
    public class MapViewModel
    {
        public Guid Id { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
    }
}