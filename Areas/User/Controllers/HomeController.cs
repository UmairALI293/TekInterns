using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace TekInternsRecord.Areas.user.Controllers
{
    [Area("User")]
    //[Authorize(Roles = "User")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
