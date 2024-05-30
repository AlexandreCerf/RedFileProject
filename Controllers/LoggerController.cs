using Microsoft.AspNetCore.Mvc;
using RedFileProject.ViewModels.LoggerPagesViewModel;

namespace RedFileProject.Controllers
{
    public class LoggerController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Add your login logic here
                return RedirectToAction("feur", "Home");
            }

            return View(model);
        }

        public IActionResult ForgotPassword()
        {
            // Add logic for forgot password
            return View();
        }
    }
}
