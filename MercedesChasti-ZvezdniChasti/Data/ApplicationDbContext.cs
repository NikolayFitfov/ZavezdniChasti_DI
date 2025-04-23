using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace MercedesChasti_ZvezdniChasti.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
