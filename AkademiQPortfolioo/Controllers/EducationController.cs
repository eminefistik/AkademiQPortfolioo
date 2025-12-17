using AkademiQPortfolioo.Data;
using Microsoft.AspNetCore.Mvc;
using PortfolyoDbContext;

namespace AkademiQPortfolioo.Controllers
{
    public class EducationController : Controller
    {

        private readonly portfolyodbContext _portfolyodbContext;

        public EducationController(portfolyodbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }


        public IActionResult EducationList()
        {
            var values = _portfolyodbContext.EducationTable.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateEducation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEducation(EducationTable educationTable) 
        {
            _portfolyodbContext.EducationTable.Add(educationTable);
            _portfolyodbContext.SaveChanges();
            return RedirectToAction("EducationList");   
        }
        [HttpGet]
        public IActionResult UpdateEducation(int id)
        {
            var values = _portfolyodbContext.EducationTable.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateEducation (EducationTable educationTable)
        {
            _portfolyodbContext.EducationTable.Update(educationTable);
            _portfolyodbContext.SaveChanges();
            return RedirectToAction("EducationList");
        }

        [HttpGet]
        public IActionResult DeleteEducation(int id) 
        {
            var values = _portfolyodbContext.EducationTable.Find(id);
            _portfolyodbContext.EducationTable.Remove(values);
            _portfolyodbContext.SaveChanges();
            return RedirectToAction("EducationList");
        }

    }
}
