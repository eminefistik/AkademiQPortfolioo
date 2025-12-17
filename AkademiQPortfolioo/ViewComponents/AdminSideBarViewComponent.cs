using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolioo.ViewComponents
{
    public class AdminSideBarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
