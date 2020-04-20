using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using BookingSystem.Authorization;
using BookingSystem.Controllers;
using BookingSystem.Users;
using BookingSystem.Web.Models.Users;

namespace BookingSystem.Web.Controllers
{
    
    public class UsersController : BookingSystemControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [AbpMvcAuthorize(AppPermissions.Pages_Users)]
        public async Task<ActionResult> Index()
        {
            var roles = (await _userAppService.GetRoles()).Items;
            var model = new UserListViewModel
            {
                Roles = roles
            };
            return View(model);
        }

        [AbpMvcAuthorize(AppPermissions.Pages_Users)]
        public async Task<ActionResult> EditModal(long userId)
        {
            var user = await _userAppService.GetAsync(new EntityDto<long>(userId));
            var roles = (await _userAppService.GetRoles()).Items;
            var model = new EditUserModalViewModel
            {
                User = user,
                Roles = roles
            };
            return PartialView("_EditModal", model);
        }

        [AbpMvcAuthorize]
        public ActionResult ChangePassword()
        {
            return View();
        }
    }
}
