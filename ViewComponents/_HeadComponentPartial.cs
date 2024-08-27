using Microsoft.AspNetCore.Mvc;

namespace MyPorftolioUdemy.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent

    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}
