using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Contextt;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultSkillComponentPartial:ViewComponent

    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var value = context.Skills.ToList();
            return View(value);
        }
    }
}
