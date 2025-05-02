using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Contextt;
using System.Net.NetworkInformation;

namespace PortfolioCore.Controllers
{
    public class StatisticsController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v0 = "İstatistikler";
            ViewBag.v1 = context.Services.Count();
            ViewBag.v2 = context.Experiences.Where(x => x.ExperienceDate == "2021-2022(Deneme)").Count();
            ViewBag.v3 = context.Skills.Count();
            ViewBag.v4 = context.Skills.Sum(x => x.SkillValue);
            ViewBag.v5=context.Experiences.Count();
            ViewBag.v6=context.Testimonials.Count();
            ViewBag.v7 = context.Categories.Count();
            ViewBag.v8 = context.Messages.Where(x => x.IsRead == true).Count();
            ViewBag.v9 = context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v10 = context.Skills.Average(x => x.SkillValue);
            return View();
        }
    }
}
