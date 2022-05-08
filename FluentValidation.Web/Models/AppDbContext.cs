using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FluentValidation.Web.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public IList<Address> Addresses { get; set; }
    }

}