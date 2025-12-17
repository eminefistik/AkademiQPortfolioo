using AkademiQPortfolioo.Data;
using Microsoft.AspNetCore.Mvc;
using PortfolyoDbContext;
using System.Drawing.Text;

namespace AkademiQPortfolioo.Controllers
{
    public class ExperienceNewController : Controller
    {
        //dependency injection
        private readonly portfolyodbContext _context;

        public ExperienceNewController(portfolyodbContext context)
        {
            _context = context;
        }

        public IActionResult ExperienceList()
        {
            var values= _context.ExperienceTables.ToList();
            
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience() 
        {
                return View();
        }
        [HttpPost]
        public IActionResult CreateExperience(ExperienceTable experienceTable) 
        {
            _context.ExperienceTables.Add(experienceTable);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");

        }



     

        [HttpGet]
        public IActionResult DeleteExperience(int id)
        {
            var value = _context.ExperienceTables.Find(id);
            _context.ExperienceTables.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");

        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var UpdateExperience = _context.ExperienceTables.Find(id);
            return View(UpdateExperience);
        }
        [HttpPost]
        public IActionResult UpdateExperience(ExperienceTable experienceTable)
        {
            _context.ExperienceTables.Update(experienceTable); //
            _context.SaveChanges(); //kaydeder 
            return RedirectToAction("ExperienceList");
        }

    }
}
