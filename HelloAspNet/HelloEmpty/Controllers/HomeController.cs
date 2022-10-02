using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloEmpty.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloEmpty.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            HelloMessage msg = new HelloMessage
            {
                Message = "Welcome to Asp.Net MVC!"
            };

            ViewBag.Noti = "Input message and click submit";

            return View(msg);
        }

        // post처리 인덱스 생성
        [HttpPost]
        public IActionResult Index(HelloMessage obj)
        {
            ViewBag.Noti = "Message Changed";
            return View(obj);
        }

    }
}
