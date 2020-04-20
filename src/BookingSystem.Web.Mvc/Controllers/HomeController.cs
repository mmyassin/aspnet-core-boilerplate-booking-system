using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using BookingSystem.Controllers;

namespace BookingSystem.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BookingSystemControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
