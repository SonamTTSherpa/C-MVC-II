using DojoSurvey.Models;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("result")]
        public IActionResult Result(User newUser)
        {
            return View(newUser);
        }
    }
}