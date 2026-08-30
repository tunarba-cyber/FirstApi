using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Reflection.Metadata;
using VerticalExample.Models;
using VerticatExample.Data;

namespace VerticalExample.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options), IAppDbContext
    {
        public DbSet<Product> Products { get; set; }

    }
}
