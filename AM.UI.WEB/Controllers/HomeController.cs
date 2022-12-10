using Microsoft.AspNetCore.Mvc;

namespace AM.UI.WEB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
