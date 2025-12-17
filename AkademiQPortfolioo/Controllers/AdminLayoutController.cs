using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolioo.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
