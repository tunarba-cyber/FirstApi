using Microsoft.EntityFrameworkCore;
using VerticalExample.Models;

namespace VerticatExample.Data
{
    public interface IAppDbContext
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}