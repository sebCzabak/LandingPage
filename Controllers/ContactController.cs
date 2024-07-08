using LandingPage.Models;
using Microsoft.AspNetCore.Mvc;

namespace LandingPage.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactFormModel model)
        {
            if(ModelState.IsValid)
            {
                //TODO
                TempData["Message"] = "Thank you for contacting us!";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
