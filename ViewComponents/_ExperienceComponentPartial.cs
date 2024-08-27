using Microsoft.AspNetCore.Mvc;
using MyPorftolioUdemy.DAL.Context;

namespace MyPorftolioUdemy.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values); 
        }
    }
}
