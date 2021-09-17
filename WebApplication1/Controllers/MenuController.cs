using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MenuController: Controller
    {
        public IActionResult Index()
        {
            var menu = new Menu()
            {
                Message = "Hello"
            };
            ViewBag.MyMessage = menu.Message;
            ViewData["MyMessage"] = menu.Message;
            return View(menu);
        }
    }
}
