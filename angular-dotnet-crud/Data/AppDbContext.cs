using angular_dotnet_crud.Models;
using Microsoft.EntityFrameworkCore;

namespace angular_dotnet_crud.Data
{
    public class AppDbContext : DbContext
    {


        public DbSet<Item> Items { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options) { }
        //public AppDbContext() {

        //    Database.EnsureCreated();
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        //    optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CRUDDB;Username=postgres;Password=Ultima57");
        //}
    }
}
