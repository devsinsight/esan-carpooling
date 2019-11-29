using System.Web.Mvc;

namespace AmbienteWeb.Proyecto.Carpooling.Web.Areas.Chofer
{
    public class ChoferAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Chofer";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Chofer_default",
                "Chofer/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}