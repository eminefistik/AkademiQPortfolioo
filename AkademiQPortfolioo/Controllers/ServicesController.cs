using AkademiQPortfolioo.Data;
using Microsoft.AspNetCore.Mvc;
using PortfolyoDbContext;

namespace AkademiQPortfolioo.Controllers
{

    public class ServicesController : Controller
    {
        private readonly portfolyodbContext _portfolyodbContext;
        public ServicesController(portfolyodbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }
        public IActionResult Index()
        {
            var values = _portfolyodbContext.ServicesTables.ToList();
            return View(values);
        }
        public IActionResult CreateServices()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateServices(ServicesTable servicesTable)
        {
            _portfolyodbContext.ServicesTables.Add(servicesTable);
            _portfolyodbContext.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateServices(int id)
        {
            var value = _portfolyodbContext.ServicesTables.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateServices(ServicesTable servicesTable)
        {
            _portfolyodbContext.ServicesTables.Update(servicesTable);
            _portfolyodbContext.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult DeleteServices(int id) 
        {
            var value = _portfolyodbContext.ServicesTables.Find(id);
            _portfolyodbContext.ServicesTables.Remove(value);
            _portfolyodbContext.SaveChanges();
            return RedirectToAction("Index");

        }
    }
    
    
}
