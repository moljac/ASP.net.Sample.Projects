using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVC4BasicRazor.netfx4
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}