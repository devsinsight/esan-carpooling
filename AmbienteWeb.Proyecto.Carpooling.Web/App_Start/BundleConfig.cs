using System.Web;
using System.Web.Optimization;

namespace AmbienteWeb.Proyecto.Carpooling.Web
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/assets/js/jquery.min.js",
                        "~/Content/assets/js/popper.js",
                        "~/Content/assets/js/tooltip.js",
                        "~/Content/assets/plugins/bootstrap/js/bootstrap.min.js",
                        "~/Content/assets/plugins/nicescroll/jquery.nicescroll.min.js",
                        "~/Content/assets/plugins/scroll-up-bar/dist/scroll-up-bar.min.js",
                        "~/Content/assets/plugins/toggle-menu/sidemenu.js",
                        "~/Content/assets/js/chart.min.js",
                        "~/Content/assets/plugins/othercharts/jquery.knob.js",
                        "~/Content/assets/plugins/othercharts/jquery.sparkline.min.js",
                        "~/Content/assets/plugins/morris/morris.min.js",
                        "~/Content/assets/plugins/morris/raphael.min.js",
                        "~/Content/assets/plugins/scroll-bar/jquery.mCustomScrollbar.concat.min.js",
                        "~/Content/assets/plugins/fullcalendar/calendar.min.js",
                        "~/Content/assets/js/apexcharts.js",
                        "~/Content/assets/js/scripts.js",
                        //"~/Content/assets/js/dashboard.js",
                        "~/Content/assets/plugins/echarts/echarts.js",
                        "~/Content/assets/js/othercharts.js",
                        "~/Content/assets/plugins/Datatable/js/jquery.dataTables.js",
                        "~/Content/assets/plugins/Datatable/js/dataTables.bootstrap4.js"
                        ));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/ajax-unobtrusive").Include(
                        "~/Scripts/jquery.unobtrusive-ajax.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/assets/plugins/bootstrap/css/bootstrap.min.css",
                      "~/Content/assets/css/icons.css",
                      "~/Content/assets/css/style.css",
                      "~/Content/assets/plugins/scroll-bar/jquery.mCustomScrollbar.css",
                      "~/Content/assets/plugins/toggle-menu/sidemenu.css",
                      "~/Content/assets/plugins/morris/morris.css",
                      "~/Content/assets/plugins/chartist/chartist.css",
                      "~/Content/assets/plugins/chartist/chartist-plugin-tooltip.css",
                      "~/Content/assets/plugins/Datatable/css/dataTables.bootstrap4.css",
                      "~/Content/site.css"));
        }
    }
}
