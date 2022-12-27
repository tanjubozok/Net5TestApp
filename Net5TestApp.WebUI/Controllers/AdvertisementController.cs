using Microsoft.AspNetCore.Mvc;

namespace Net5TestApp.WebUI.Controllers
{
    public class AdvertisementController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Send()
        {
            return View();
        }
    }
}
