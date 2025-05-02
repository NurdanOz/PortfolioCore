using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Entities;
using PortfolioCore.Contextt;

namespace PortfolioCore.Controllers
{
    public class SendMessageController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
            ViewBag.Success = "Gönderim İşlemi Başarılı";
            return View("~/Views/Default/Index.cshtml");
        }
    }
}
﻿