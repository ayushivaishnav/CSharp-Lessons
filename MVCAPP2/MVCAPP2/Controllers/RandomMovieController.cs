using Microsoft.AspNetCore.Mvc;

namespace MVCAPP2.Controllers
{
	public class RandomMovieController : Controller
	{
		public ActionResult Start()
		{
			return View();
		}
	}
}
