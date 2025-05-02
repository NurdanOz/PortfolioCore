using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Contextt;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultPortfolioComponentPartial:ViewComponent

    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
           
            return View();
        }

    }
}
