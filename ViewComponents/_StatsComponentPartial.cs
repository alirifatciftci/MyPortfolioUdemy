using Microsoft.AspNetCore.Mvc;

namespace MyPorftolioUdemy.ViewComponents
{
    public class _StatsComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
