using Microsoft.AspNetCore.Mvc;
using PortfolyoDbContext;

namespace AkademiQPortfolioo.ViewComponents.AdminLayoutViewComponents
{
    public class PortfolioViewComponent:ViewComponent
    {
        private readonly portfolyodbContext _portfolyodbContext;

        public PortfolioViewComponent(portfolyodbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _portfolyodbContext.ProjectTables.ToList();
            return View(values);
        }
    }
}
