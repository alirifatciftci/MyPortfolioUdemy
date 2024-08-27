using Microsoft.AspNetCore.Mvc;

public class AboutController : Controller
{
    public IActionResult Index()
    {
        return View(); // Bu, "Views/About/Index.cshtml" dosyasını kullanır.
    }
}
