using Microsoft.AspNetCore.Mvc;
using SimpleDeploy.Models;
using System.Diagnostics;

namespace SimpleDeploy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Create()
        {
            return View();
        }

       
    }
}
