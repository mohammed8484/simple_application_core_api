using Microsoft.EntityFrameworkCore;
using simple_application_core_api.Models;
using System.Collections.Generic;

namespace simple_application_core_api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
