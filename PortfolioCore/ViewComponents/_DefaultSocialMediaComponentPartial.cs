using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Contextt;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultSocialMediaComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }
    }
}
