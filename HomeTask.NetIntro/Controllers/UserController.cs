using Microsoft.AspNetCore.Mvc;

namespace HomeTask.NetIntro.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.User = new string[] { "Ali", "Xudiyev", "24", "Azerbaijan", "+994553053232" };
            ViewData["Name"] = "Hikmet";
            ViewData["Surname"] = "Xidirzade";
            ViewData["Age"] = 25;
            ViewData["Country"] = "Azerbaijan";
            ViewData["PhoneNumber"] = "+994554770076";
            return View();
        }
    }
}
