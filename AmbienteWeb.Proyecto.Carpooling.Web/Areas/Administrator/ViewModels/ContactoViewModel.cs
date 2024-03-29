﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AmbienteWeb.Proyecto.Carpooling.Web.Areas.Administrator.ViewModels
{
    public class ContactoViewModel
    {
        public int? Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        [Required]
        public string DNI { get; set; }
        public string Email { get; set; }
    }
}