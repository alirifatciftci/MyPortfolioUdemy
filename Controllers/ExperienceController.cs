using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using MyPorftolioUdemy.DAL.Context;
using MyPorftolioUdemy.DAL.Entities;
using System.Security.Cryptography.Pkcs;

namespace MyPortfolioUdemy.Controllers
{
	public class ExperienceController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult ExperienceList()
		{
			var values = context.Experiences.ToList();
			return View(values);
		}

		[HttpGet] // sayfa ilk açıldıgında çalişicak
		public IActionResult CreateExperience()
		{
			return View();
		}
		[HttpPost] // sayfada bir butona tıklandıgında çalışacak
		public IActionResult CreateExperience(Experience experience)
		{
			context.Experiences.Add(experience); // ekleme işlemini yap
			context.SaveChanges(); // veritabanına kaydet 
			return RedirectToAction("ExperienceList"); // tekrar experience liste gönderme , yönlendirme
		}

		public IActionResult DeleteExperience(int id)
		{
			var value = context.Experiences.Find(id);  // silenecek deneyimi id ile  bul
			context.Experiences.Remove(value); // kaldır
			context.SaveChanges(); // dbye kaydet
			return RedirectToAction("ExperienceList"); // sayfaya geri at 

		}
		[HttpGet]

		public IActionResult UpdateExperience(int id)
			{
		     var value =context.Experiences.Find(id);
             return View(value);
			}


		[HttpPost]
		public IActionResult UpdateExperience(Experience experience)
		{
			context.Experiences.Update(experience);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");

		}
					
	}
	}

