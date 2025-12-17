using Microsoft.AspNetCore.Mvc;
using PortfolyoDbContext;

namespace AkademiQPortfolioo.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly portfolyodbContext _context;

        public ExperienceController(portfolyodbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult CreateExperience()
        {
            return View();
        }
        public IActionResult UpdateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteExperience()
        {
            return View();
        }
    }
}
