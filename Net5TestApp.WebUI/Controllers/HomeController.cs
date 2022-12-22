using Microsoft.AspNetCore.Mvc;
using Net5TestApp.Business.Interfaces;
using Net5TestApp.WebUI.Extensions;
using System.Threading.Tasks;

namespace Net5TestApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProvidedServiceService _providedServiceService;
        private readonly IAdvertisementService _advertisementService;

        public HomeController(IProvidedServiceService providedServiceService, IAdvertisementService advertisementService)
        {
            _providedServiceService = providedServiceService;
            _advertisementService = advertisementService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _providedServiceService.GetAllAsync();
            return this.ResponseView(response);
        }

        public async Task<IActionResult> HumanResource()
        {
            var response = await _advertisementService.GetActivesAsync();
            return this.ResponseView(response);
        }
    }
}
