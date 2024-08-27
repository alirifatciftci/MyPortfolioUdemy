using Microsoft.AspNetCore.Mvc;

namespace MyPorftolioUdemy.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
