using Microsoft.AspNetCore.Mvc;

namespace ErgunAkaryakitWebProject.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
