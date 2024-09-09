using Microsoft.AspNetCore.Mvc;

namespace WebApplication1
{
	public class HomeController : Controller
	{
		public ContentResult Index()
		{
			ContentResult result = new ContentResult();
			result.Content = "hello in homecontroller this is index content";
			return result;
		}
	}
}
