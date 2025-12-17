using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolioo.ViewComponents
{
    public class SkillViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }

    }
}
