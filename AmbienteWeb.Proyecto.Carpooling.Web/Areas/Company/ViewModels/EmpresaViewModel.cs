using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmbienteWeb.Proyecto.Carpooling.Web.Areas.Company.ViewModels
{
    public class EmpresaViewModel
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string RUC { get; set; }
        public string TipoPagoId { get; set; }

    }
}