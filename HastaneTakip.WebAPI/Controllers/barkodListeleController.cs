using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HastaneTakip.WebAPI.Models;

namespace HastaneTakip.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class barkodListeleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public barkodListeleController(ApplicationDbContext context)
        {
            _context = context;
        }

      

        // GET: api/barkodListele/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BarkodOlustur>> GetbarkodOlustur(int id)
        {
          
            
            var barkodOlustur = await _context.barkodOlusturs.FindAsync(id);

            if (barkodOlustur == null)
            {
                return NotFound();
            }

            return barkodOlustur;
        }

      
    }
}
