using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HastaneTakipSistemi.Data;
using HastaneTakipSistemi.Models;
using Microsoft.AspNetCore.Authorization;

namespace HastaneTakipSistemi.Controllers
{
    [Authorize(Roles ="admin")]
    public class HastaYapilanIslemlersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HastaYapilanIslemlersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HastaYapilanIslemlers
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.hastaYapilanIslemlers.Include(h => h.barkodOlustur);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: HastaYapilanIslemlers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.hastaYapilanIslemlers == null)
            {
                return NotFound();
            }

            var hastaYapilanIslemler = await _context.hastaYapilanIslemlers
                .Include(h => h.barkodOlustur)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hastaYapilanIslemler == null)
            {
                return NotFound();
            }

            return View(hastaYapilanIslemler);
        }

        // GET: HastaYapilanIslemlers/Create
        public IActionResult Create()
        {
            ViewData["barkodOlusturId"] = new SelectList(_context.barkodOlusturs, "Id", "Id");
            return View();
        }

        // POST: HastaYapilanIslemlers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,giris,cikis,tedaviAciklamasi,barkodOlusturId")] HastaYapilanIslemler hastaYapilanIslemler)
        {

            ViewData["barkodOlusturId"] = new SelectList(_context.barkodOlusturs, "Id", "Id", hastaYapilanIslemler.barkodOlusturId);

                 _context.Add(hastaYapilanIslemler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
        }

        // GET: HastaYapilanIslemlers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.hastaYapilanIslemlers == null)
            {
                return NotFound();
            }

            var hastaYapilanIslemler = await _context.hastaYapilanIslemlers.FindAsync(id);
            if (hastaYapilanIslemler == null)
            {
                return NotFound();
            }
            ViewData["barkodOlusturId"] = new SelectList(_context.barkodOlusturs, "Id", "Id", hastaYapilanIslemler.barkodOlusturId);
            return View(hastaYapilanIslemler);
        }

        // POST: HastaYapilanIslemlers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,giris,cikis,tedaviAciklamasi,barkodOlusturId")] HastaYapilanIslemler hastaYapilanIslemler)
        {
            if (id != hastaYapilanIslemler.Id)
            {
                return NotFound();
            }

            ViewData["barkodOlusturId"] = new SelectList(_context.barkodOlusturs, "Id", "Id", hastaYapilanIslemler.barkodOlusturId);

            try
            {
                    _context.Update(hastaYapilanIslemler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HastaYapilanIslemlerExists(hastaYapilanIslemler.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            
        }

        // GET: HastaYapilanIslemlers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.hastaYapilanIslemlers == null)
            {
                return NotFound();
            }

            var hastaYapilanIslemler = await _context.hastaYapilanIslemlers
                .Include(h => h.barkodOlustur)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hastaYapilanIslemler == null)
            {
                return NotFound();
            }

            return View(hastaYapilanIslemler);
        }

        // POST: HastaYapilanIslemlers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.hastaYapilanIslemlers == null)
            {
                return Problem("Entity set 'ApplicationDbContext.hastaYapilanIslemlers'  is null.");
            }
            var hastaYapilanIslemler = await _context.hastaYapilanIslemlers.FindAsync(id);
            if (hastaYapilanIslemler != null)
            {
                _context.hastaYapilanIslemlers.Remove(hastaYapilanIslemler);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HastaYapilanIslemlerExists(int id)
        {
          return (_context.hastaYapilanIslemlers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
