using Microsoft.AspNetCore.Mvc;
using MyPorftolioUdemy.DAL.Context;

namespace MyPorftolioUdemy.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values); 
        }
    }
}
