using Microsoft.AspNetCore.Mvc;
using PortfolyoDbContext;

namespace AkademiQPortfolioo.ViewComponents
{
    public class ExperienceViewComponent : ViewComponent
    {
        private readonly portfolyodbContext _portfolyodbContext;

        public ExperienceViewComponent(portfolyodbContext portfolyodbContext)
        {
            _portfolyodbContext = portfolyodbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _portfolyodbContext.ExperienceTables.ToList();
            return View(values);
        }

    }
}
