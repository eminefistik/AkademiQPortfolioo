using Microsoft.AspNetCore.Mvc;
using PortfolyoDbContext;

namespace AkademiQPortfolioo.Controllers
{
    public class ContactController : Controller
    {
        private readonly portfolyodbContext _context;

        public ContactController(portfolyodbContext context)
        {
            _context = context;
        }

        public IActionResult ContactList()
        {
            var values = _context.ContactTables.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult DeleteContact(int id) 
        {
            var value = _context.ContactTables.Find(id);
            _context.ContactTables.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("ContactList");

        }
    }
}
