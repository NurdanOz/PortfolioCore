using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Contextt;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultProjectComponentPartial:ViewComponent
    {
        PortfolioContext context=new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }
    }
}
