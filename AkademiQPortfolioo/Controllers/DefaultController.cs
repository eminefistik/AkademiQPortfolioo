using AkademiQPortfolioo.Data;
using Microsoft.AspNetCore.Mvc;
using PortfolyoDbContext;

namespace AkademiQPortfolioo.Controllers
{
    public class DefaultController : Controller
    {
        private readonly portfolyodbContext _portfolyodbContext;

        public DefaultController(portfolyodbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IActionResult Index()
        {
            var values = _portfolyodbContext.ServicesTables.ToList();
            return View(values);
        }

      
    }
}
