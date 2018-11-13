using System.Web;
using System.Web.Mvc;

namespace Asp_Scaffolding_test_1
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
