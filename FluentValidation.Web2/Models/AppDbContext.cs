using Microsoft.EntityFrameworkCore;

namespace FluentValidation.Web2.Models
{
    public class AppDbContext:DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        public DbSet<Customer> Customers { get; set; }
    }
}
