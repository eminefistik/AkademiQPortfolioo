using Microsoft.AspNetCore.Mvc;
using PortfolyoDbContext;

namespace AkademiQPortfolioo.ViewComponents.AdminLayoutViewComponents
{
    public class ContactViewComponent:ViewComponent
    {
        private readonly portfolyodbContext _portfolyodbContext;

        public ContactViewComponent(portfolyodbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values= _portfolyodbContext.ContactTables.ToList();
            return View(values);
        }
    }
}
