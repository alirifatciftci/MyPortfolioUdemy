using Microsoft.AspNetCore.Mvc;
using MyPorftolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
	public class StatisticController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.v1 = context.Skills.Count(); // // ViewBag, controller'dan view'a veri taşımak için kullanılır.
// Örnek: Müşteriden gelen "Mutlu Yıllar!" mesajını pastaya yazmak gibi.
            ViewBag.v2 = context.Messages.Count();
			ViewBag.v3 = context.Messages.Where(x => x.IsRead ==false).Count(); // okunmayan mesajları sayma kodu 
			ViewBag.v4 = context.Messages.Where(x => x.IsRead ==true).Count(); 
			return View();
		}
	}
}
