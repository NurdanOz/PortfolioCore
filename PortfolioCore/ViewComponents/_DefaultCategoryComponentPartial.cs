using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Contextt;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultCategoryComponentPartial : ViewComponent

    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var value = context.Categories.ToList();
            return View(value);
        }

    }   
}
