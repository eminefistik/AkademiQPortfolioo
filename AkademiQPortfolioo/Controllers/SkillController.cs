using AkademiQPortfolioo.Data;
using Microsoft.AspNetCore.Mvc;
using PortfolyoDbContext;

namespace AkademiQPortfolioo.Controllers
{
    public class SkillController : Controller
    {

        private readonly portfolyodbContext _portfolyodbContext;
        public SkillController(portfolyodbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IActionResult Index()
        {
            var SkillList = _portfolyodbContext.SkilTables.ToList();
            return View(SkillList);
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var SkillUpdate = _portfolyodbContext.SkilTables.Find(id);
            return View(SkillUpdate);
        }
        [HttpPost]
        public IActionResult UpdateSkill(SkilTable skill)
        {
            _portfolyodbContext.SkilTables.Update(skill); //
            _portfolyodbContext.SaveChanges(); //kaydeder 
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id) 
        {
            var value = _portfolyodbContext.SkilTables.Find(id);
            _portfolyodbContext.SkilTables.Remove(value);
            _portfolyodbContext.SaveChanges(); //kaydeder 
            return RedirectToAction("Index");

        }
        
        [HttpGet]
        public IActionResult CreateSkill(int id)
        {
            var CreateSkill = _portfolyodbContext.SkilTables.Find(id);
            return View();
        }
        [HttpPost]
        public IActionResult CreateSkill(SkilTable skill)
        {
            _portfolyodbContext.SkilTables.Add(skill); //
            _portfolyodbContext.SaveChanges(); /*//kaydeder */
            return RedirectToAction("Index");
        }

    }
}
