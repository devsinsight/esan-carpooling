using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace AmbienteWeb.Proyecto.Carpooling.Web.Models.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetRazonSocial(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("RazonSocial");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }

        //public static string GetUserLastName(this IIdentity identity)
        //{
        //    var claim = ((ClaimsIdentity)identity).FindFirst("LastName");
        //    // Test for null to avoid issues during local testing
        //    return (claim != null) ? claim.Value : string.Empty;
        //}
    }
}