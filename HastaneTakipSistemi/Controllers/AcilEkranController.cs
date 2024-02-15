using HastaneTakipSistemi.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HastaneTakipSistemi.Controllers
{
    public class AcilEkranController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AcilEkranController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize]
        public IActionResult Ekran()
        {
            var liste= _context.barkodOlusturs.ToList();

            return View(liste);
        }
    }
}
