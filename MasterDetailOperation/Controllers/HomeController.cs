using Microsoft.AspNetCore.Mvc;

namespace MasterDetailOperation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
