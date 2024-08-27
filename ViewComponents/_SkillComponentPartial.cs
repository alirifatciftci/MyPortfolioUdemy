using Microsoft.AspNetCore.Mvc;
using MyPorftolioUdemy.DAL.Context;

namespace MyPorftolioUdemy.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=context.Skills.ToList();
            return View(values); 
        }
    }
}
