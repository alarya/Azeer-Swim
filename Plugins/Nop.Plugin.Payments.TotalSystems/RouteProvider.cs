using System.Web.Mvc;
using System.Web.Routing;
using Nop.Web.Framework.Mvc.Routes;

namespace Nop.Plugin.Payments.TotalSystems
{
    public partial class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            //IPN
            routes.MapRoute("Plugin.Payments.TotalSystems.IPNHandler",
                 "Plugins/PaymentTotalSystems/IPNHandler",
                 new { controller = "PaymentTotalSystems", action = "IPNHandler" },
                 new[] { "Nop.Plugin.Payments.TotalSystems.Controllers" }
            );
        }
        public int Priority
        {
            get
            {
                return 0;
            }
        }
    }
}
