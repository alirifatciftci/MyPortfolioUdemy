using Microsoft.AspNetCore.Mvc;

namespace MyPorftolioUdemy.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
