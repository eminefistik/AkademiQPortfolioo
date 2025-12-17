using AkademiQPortfolioo.Data;
using Microsoft.AspNetCore.Mvc;
using PortfolyoDbContext;

namespace AkademiQPortfolioo.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly portfolyodbContext _context;

        public TestimonialController(portfolyodbContext context)
        {
            _context = context;
        }

        public IActionResult TestimonialList()
        {
            var values = _context.TestimonialTables.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _context.TestimonialTables.Find(id);
            _context.TestimonialTables.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("TestimonialList");


        }
        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTestimonial(TestimonialTable testimonialTable)
        {
            _context.TestimonialTables.Add(testimonialTable);
            _context.SaveChanges();
            return RedirectToAction("TestimonialList");


        }
    }
}
