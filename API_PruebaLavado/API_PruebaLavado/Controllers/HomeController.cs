using Microsoft.AspNetCore.Mvc;

namespace API_PruebaLavado.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
