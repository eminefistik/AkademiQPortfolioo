using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolioo.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
