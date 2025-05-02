using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Page404()
        {
           
            return View();
        }
    }
}
