using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IntroductionASPNETCoreMVC.Models;

namespace IntroductionASPNETCoreMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<IntroductionASPNETCoreMVC.Models.Samochod> Samochod { get; set; } = default!;
        public DbSet<IntroductionASPNETCoreMVC.Models.Category> Category { get; set; } = default!;
        public DbSet<IntroductionASPNETCoreMVC.Models.Product> Product { get; set; } = default!;
    }
}
