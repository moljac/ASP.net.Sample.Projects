﻿using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVC4MobileRazor.netfx4
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}