using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Net5TestApp.Business.Abstract;
using Net5TestApp.Common.Enums;
using Net5TestApp.Dtos.Concrete.AppUserDtos;
using Net5TestApp.Dtos.Concrete.MilitaryStatusDtos;
using Net5TestApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Net5TestApp.WebUI.Controllers
{
    public class AdvertisementController : Controller
    {
        private readonly IAppUserService _appUserService;

        public AdvertisementController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult List()
        {
            return View();
        }

        [Authorize(Roles = "Member")]
        public async Task<IActionResult> Send(int advertisementId)
        {
            var userId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value);
            var userResponse = await _appUserService.GetByIdAsync<AppUserListDto>(userId);

            ViewBag.GenderId = userResponse.Data.GenderId;

            var items = Enum.GetValues(typeof(MilitaryStatusTypes));
            var list = new List<MilitaryStatusListDto>();
            foreach (var item in items)
            {
                list.Add(new MilitaryStatusListDto
                {
                    Id = (int)item,
                    Definition = Enum.GetName(typeof(MilitaryStatusTypes), (int)item)
                });
            }
            ViewBag.MilitaryStatus = new SelectList(list, "Id", "Definition");

            return View(new AdvertisementAppUserCreateModel
            {
                AdvertisementId = advertisementId,
                AppUserId = userId
            });
        }

        [HttpPost]
        [Authorize(Roles = "Member")]
        public async Task<IActionResult> Send(AdvertisementAppUserCreateModel model)
        {
            return View();
        }
    }
}
