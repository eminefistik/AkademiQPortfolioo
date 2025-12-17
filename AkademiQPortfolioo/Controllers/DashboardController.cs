using Microsoft.AspNetCore.Mvc;
using PortfolyoDbContext;

namespace AkademiQPortfolioo.Controllers
{
    public class DashboardController : Controller
    {
        private readonly portfolyodbContext _portfolyodbContext;

        public DashboardController(portfolyodbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IActionResult Index()
        {
            ViewBag.FirstProject = _portfolyodbContext.ProjectTables.FirstOrDefault().ProjectName;
            ViewBag.LastProject = _portfolyodbContext.ProjectTables.OrderByDescending(x => x.ProjectId).FirstOrDefault().ProjectName;

            ViewBag.TotalServicesCount = _portfolyodbContext.ServicesTables.Count();

            ViewBag.FirstCategory = _portfolyodbContext.CategoriesTables.FirstOrDefault().CategoryName;

            ViewBag.TotalTestimonialCount = _portfolyodbContext.TestimonialTables
                .Count();
            ViewBag.totalmessagge = _portfolyodbContext.ContactTables.Count();
            ViewBag.Lastexperience = _portfolyodbContext.ExperienceTables.OrderByDescending(x => x.ExperienceId).FirstOrDefault().DescriptionTitle;
            // Task
            var firstTestimonial = _portfolyodbContext.TestimonialTables
                                            .OrderBy(x => x.TestimonialId) // isteğe bağlı
                                            .FirstOrDefault();

            ViewBag.FirstTestimonialComment = firstTestimonial?.NameSurname;

            ViewBag.Totalskill = _portfolyodbContext.SkilTables.Count();

            // 1-) En çok projeye sahip kategori

            // 2-) Yenekler tablosunda en yüksek levelli yetenek

            // 3 Tanesini de siz belirleyin
            return View();

        }
    }
}
