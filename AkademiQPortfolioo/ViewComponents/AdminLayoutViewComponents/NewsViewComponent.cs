using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolioo.ViewComponents.AdminLayoutViewComponents
{
    public class NewsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
