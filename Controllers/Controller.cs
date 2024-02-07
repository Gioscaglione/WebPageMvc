using Microsoft.AspNetCore.Mvc;

namespace WebPageMvc.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
