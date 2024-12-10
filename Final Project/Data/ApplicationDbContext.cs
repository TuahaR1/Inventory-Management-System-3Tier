using Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Final_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }
    }
}
