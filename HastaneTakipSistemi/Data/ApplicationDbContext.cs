using HastaneTakipSistemi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HastaneTakipSistemi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BarkodOlustur> barkodOlusturs { get; set; }
        public DbSet<HastaYapilanIslemler> hastaYapilanIslemlers { get; set; }

    }
}