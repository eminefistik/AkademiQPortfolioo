using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolioo.ViewComponents.AdminLayoutViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }

    }
}
