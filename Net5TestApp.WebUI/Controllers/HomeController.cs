using Microsoft.AspNetCore.Mvc;
using Net5TestApp.Business.Interfaces;
using System.Threading.Tasks;

namespace Net5TestApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProvidedServiceService _providedServiceService;

        public HomeController(IProvidedServiceService providedServiceService)
        {
            _providedServiceService = providedServiceService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _providedServiceService.GetAllAsync();
            return View(list);
        }
    }
}
