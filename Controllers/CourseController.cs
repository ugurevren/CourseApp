using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm] Candidate candidate)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (Repository.Candidates.Any(c=>c.Email == candidate.Email))
            {
                ModelState.AddModelError("Email", "You have already applied!");
                return View();
            }

            Repository.Add(candidate);
            return View("Feedback",candidate);
        }

    }
}