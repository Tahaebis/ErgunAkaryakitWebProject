using Microsoft.AspNetCore.Mvc;

namespace ErgunAkaryakitWebProject.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
