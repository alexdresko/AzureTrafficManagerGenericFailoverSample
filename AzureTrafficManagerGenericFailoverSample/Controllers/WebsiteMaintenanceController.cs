using System.Web.Mvc;

namespace AzureTrafficManagerGenericFailoverSample.Controllers
{
	public class WebsiteMaintenanceController : Controller
	{
		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}