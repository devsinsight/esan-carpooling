using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AmbienteWeb.Proyecto.Carpooling.Web.Startup))]
namespace AmbienteWeb.Proyecto.Carpooling.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
