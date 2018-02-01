using System.Web.Mvc;

namespace JenkinsDemo.Controllers
{
    public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public int Add(int a, int b)
		{
			return a + b;
		}

		public int Subtract(int a, int b)
		{
			return a - b;
		}
	}
}
