using Microsoft.EntityFrameworkCore;

namespace HastaneTakip.WebAPI.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       public DbSet<BarkodOlustur> barkodOlusturs { get; set; } 
    }
}
