using Microsoft.AspNetCore.Mvc;

namespace MyPorftolioUdemy.ViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
