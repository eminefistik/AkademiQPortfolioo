using AkademiQPortfolioo.Data;
using Microsoft.AspNetCore.Mvc;
using PortfolyoDbContext;

namespace AkademiQPortfolioo.Controllers
{
    public class SkillNewController : Controller
    {
        private readonly portfolyodbContext _context;

        public SkillNewController(portfolyodbContext context)
        {
            _context = context;
        }

        public IActionResult SkillList()
        {
            var values = _context.SkilTables.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSkill(SkilTable skilTable)
        {
            _context.SkilTables.Add(skilTable);
            _context.SaveChanges();
            return RedirectToAction("SkillList");
        }


        [HttpGet]
        public IActionResult DeleteSkill(int id)
        {
            var value = _context.SkilTables.Find(id);
            _context.SkilTables.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("SkillList");

        }

        [HttpGet]
        public IActionResult SkillUpdate(int id)
        {
            var SkilUpdate = _context.SkilTables.Find(id);
            return View(SkilUpdate);
        }
        [HttpPost]
        public IActionResult SkillUpdate(SkilTable skilTable)
        {
            _context.SkilTables.Update(skilTable); //
            _context.SaveChanges(); //kaydeder 
            return RedirectToAction("SkillList");
        }
    }
}