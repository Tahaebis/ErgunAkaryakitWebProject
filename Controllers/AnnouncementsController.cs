using Microsoft.AspNetCore.Mvc;

namespace ErgunAkaryakitWebProject.Controllers
{
    public class AnnouncementsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
