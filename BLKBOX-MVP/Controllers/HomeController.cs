using BLKBOX_MVP.Models;
using Microsoft.AspNetCore.Mvc;

namespace BLKBOX_MVP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult BeginWorkout()
        {
            return View();
        }

        public IActionResult Workouts()
        {
            return View(new WorkoutsViewModel());
        }

        public IActionResult Holding()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}