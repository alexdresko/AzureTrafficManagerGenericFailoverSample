using System.Web.Mvc;

namespace AzureTrafficManagerGenericFailoverSample
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}