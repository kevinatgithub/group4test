using ClassLibrary1;
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
        private readonly Order order;

        public MenuController(Order order)
        {
            this.order = order;
        }

        public IActionResult Index()
        {
            var menu = new Menu()
            {
                Message = "Hello"
            };
            ViewBag.MyMessage = menu.Message;
            ViewData["MyMessage"] = menu.Message;

            var order = new Order();

            return View(menu);
        }
    }
}
