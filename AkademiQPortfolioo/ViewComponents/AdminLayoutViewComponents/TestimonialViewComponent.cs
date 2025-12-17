using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;
using PortfolyoDbContext;

namespace AkademiQPortfolioo.ViewComponents.AdminLayoutViewComponents
{
    public class TestimonialViewComponent : ViewComponent
    {
        private readonly portfolyodbContext _portfolydbContext;

        public TestimonialViewComponent(portfolyodbContext portfolydbContext)
        {
            _portfolydbContext = portfolydbContext;
        }
         
        
        public IViewComponentResult Invoke()
        {
            var values = _portfolydbContext.TestimonialTables.ToList();
            return View(values);
        }

       
        

    }
}
