using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolioo.ViewComponents
{
    public class AdminHeadViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View(); 
        }
    }
}
