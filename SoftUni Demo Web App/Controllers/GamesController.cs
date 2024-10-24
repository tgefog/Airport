using Microsoft.AspNetCore.Mvc;

namespace SoftUni_Demo_Web_App.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Details()
        {
            List<string> courseList = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                courseList.Add($"Game ID: {i}");
            }
            return View(courseList);
        }
    }
}
