using Microsoft.AspNetCore.Mvc;
using PortfolyoDbContext;

namespace AkademiQPortfolioo.ViewComponents.AdminLayoutViewComponents
{
    public class AboutViewComponent:ViewComponent
    {
        private readonly portfolyodbContext _portfolyodbContext;

        public AboutViewComponent(portfolyodbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _portfolyodbContext.AboutTables.ToList();
            return View(values);
        }
    }
}
