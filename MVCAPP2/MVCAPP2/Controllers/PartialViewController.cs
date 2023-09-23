using Microsoft.AspNetCore.Mvc;

namespace MVCAPP2.Controllers
{
    public class PartialViewController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tabs()
        {
            ViewData["data"] = "Tom and Jerry are good friends";
            return View();
        }
    }
}
