using Microsoft.AspNetCore.Mvc;
using SoftUni_Demo_Web_App.Models;
using System.Diagnostics;

namespace SoftUni_Demo_Web_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Details()
        {
            List<string> courseList = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                courseList.Add($"Course ID: {i}");
            }
            return View(courseList);
        }
        public IActionResult Fog()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}