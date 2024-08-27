using Microsoft.AspNetCore.Mvc;

namespace MyPorftolioUdemy.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(); 
        }
    }
}
