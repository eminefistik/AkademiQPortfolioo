using AkademiQPortfolioo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolyoDbContext;

namespace AkademiQPortfolioo.Controllers
{
    public class AboutController : Controller
    {
        private readonly portfolyodbContext _portfolyodbContext;

        public AboutController(portfolyodbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }


        public IActionResult AboutList()
        {
            var values=_portfolyodbContext.AboutTables.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateAbout()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult CreateAbout(AboutTable aboutTable)
        {
          _portfolyodbContext.AboutTables.Add(aboutTable);
            _portfolyodbContext.SaveChanges();
            return RedirectToAction("AboutList");
        }



        [HttpGet]
        public IActionResult DeleteAbout(int id)
        {
            var value = _portfolyodbContext.AboutTables.Find(id);
            _portfolyodbContext.AboutTables.Remove(value);
            _portfolyodbContext.SaveChanges();
            return RedirectToAction("AboutList");

        }

        [HttpGet]
        public IActionResult AboutUpdate(int id)
        {
            var values = _portfolyodbContext.AboutTables.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult AboutUpdate(AboutTable aboutTable)
        {
            _portfolyodbContext.AboutTables.Update(aboutTable); //
            _portfolyodbContext.SaveChanges(); //kaydeder 
            return RedirectToAction("AboutList");
        }

    }
}
