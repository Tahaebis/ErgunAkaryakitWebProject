using Microsoft.AspNetCore.Mvc;

namespace ErgunAkaryakitWebProject.Controllers
{
    public class StationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
