using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Contextt;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class SocialMediaController : Controller

      {

       PortfolioContext context = new PortfolioContext();

        public IActionResult SMList()
        {
            var value = context.SocialMedias.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult SMAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SMAdd(SocialMedia socialMedia)
        {
            context.SocialMedias.Add(socialMedia);
            context.SaveChanges();
            return RedirectToAction("SMList");
        }

        public IActionResult SMDelete(int id)
        {
            var value = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SMList");
        }

        [HttpGet]
        public IActionResult SMUpdate(int id)
        {
            var value = context.SocialMedias.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult SMUpdate(SocialMedia socialMedia)
        {
            context.SocialMedias.Update(socialMedia);
            context.SaveChanges();
            return RedirectToAction("SMList");
        }
    }
}
