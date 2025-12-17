using AkademiQPortfolioo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PortfolyoDbContext;

namespace AkademiQPortfolioo.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly portfolyodbContext _portfolyodbContext;

        public ProjectsController(portfolyodbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IActionResult Index()
        {
            var value = _portfolyodbContext.ProjectTables.Include(x => x.Category).ToList(); //include projeyi çek ama kategorileride getir
            return View(value);
        }

        [HttpGet]
        public IActionResult ProjectCreate()
        {

            ViewBag.Categories = _portfolyodbContext.CategoriesTables.Select(
                x => new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CategoryId.ToString()

                }
                );
            return View();
        }
        [HttpPost]
        public IActionResult ProjectCreate(ProjectTable projectsTable)
        {
            _portfolyodbContext.ProjectTables.Add(projectsTable);
            _portfolyodbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ProjectUpdate(int id)
        {
            var SkilUpdate = _portfolyodbContext.ProjectTables.Find(id);
            return View(SkilUpdate);
        }
        [HttpPost]
        public IActionResult ProjectUpdate(ProjectTable projectsTable)
        {
            _portfolyodbContext.ProjectTables.Update(projectsTable); 
            _portfolyodbContext.SaveChanges(); //kaydeder 
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteProject(int id)
        {
            var value= _portfolyodbContext.ProjectTables.Find(id);
            _portfolyodbContext.ProjectTables.Remove(value);
            _portfolyodbContext.SaveChanges();
            return RedirectToAction("Index");

        }
    }
    
}
// güncelleeeme yapılacak