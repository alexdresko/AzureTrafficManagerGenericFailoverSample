using System.Web.Mvc;
using System.Web.Routing;

namespace AzureTrafficManagerGenericFailoverSample
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute("WebsiteMaintenance", "WebsiteMaintenance/{action}/{id}", new { controller = "WebsiteMaintenance", id = UrlParameter.Optional });

			routes.MapRoute("CatchAll", "{*url}", new { controller = "Home", action = "Index", url = UrlParameter.Optional });
		}
	}
}