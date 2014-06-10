using System.Web.Mvc;

namespace AzureTrafficManagerGenericFailoverSample.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			Session["UrlToUse"] = Request.Url.AbsoluteUri;

			return View();
		}
	}
}