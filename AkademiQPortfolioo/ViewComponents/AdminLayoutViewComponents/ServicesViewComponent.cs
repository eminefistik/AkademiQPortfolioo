using Microsoft.AspNetCore.Mvc;
using PortfolyoDbContext;

namespace AkademiQPortfolioo.ViewComponents.AdminLayoutViewComponents
{
    public class ServicesViewComponent : ViewComponent
    {
        private readonly portfolyodbContext _portfolydbContext;

        public ServicesViewComponent(portfolyodbContext portfolydbContext)
        {
            _portfolydbContext = portfolydbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _portfolydbContext.ServicesTables.ToList();
            return View(values);
        }
    }
}
