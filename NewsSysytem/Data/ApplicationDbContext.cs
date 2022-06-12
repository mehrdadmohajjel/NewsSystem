using Microsoft.EntityFrameworkCore;
using NewsSysytem.Models;

namespace NewsSysytem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
        public DbSet<Category>Categories { get; set; }       


    }
}
