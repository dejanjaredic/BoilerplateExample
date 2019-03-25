using Microsoft.AspNetCore.Mvc;

namespace BoilerplateExample.Web.Controllers
{
    public class HomeController : BoilerplateExampleControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}