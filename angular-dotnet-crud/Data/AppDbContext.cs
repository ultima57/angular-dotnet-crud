using angular_dotnet_crud.Models;
using Microsoft.EntityFrameworkCore;

namespace angular_dotnet_crud.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
    }
}
