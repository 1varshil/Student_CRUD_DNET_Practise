using Microsoft.AspNetCore.Mvc;

namespace StudentPortal.Web.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
