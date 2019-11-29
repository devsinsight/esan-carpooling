using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmbienteWeb.Proyecto.Carpooling.Web.Models
{
    public class PaymentViewModel
    {
        public int Id { get; set; }
        public int TipoPagoId { get; set; }
        public string NumeroTarjeta { get; set; }
    }

}