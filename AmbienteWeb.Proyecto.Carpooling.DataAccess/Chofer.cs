//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AmbienteWeb.Proyecto.Carpooling.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chofer
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Placa { get; set; }
        public string ModeloVehiculo { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
    }
}