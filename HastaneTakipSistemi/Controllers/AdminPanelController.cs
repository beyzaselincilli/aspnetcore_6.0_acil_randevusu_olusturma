using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace HastaneTakipSistemi.Controllers
{
    public class AdminPanelController : Controller
    {
        [Authorize(Roles = "admin")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
