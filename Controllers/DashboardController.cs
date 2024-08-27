using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.Models;

namespace MyPortfolioUdemy.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var model = new DashboardViewModel();
            return View(model);
        }
    }
}
