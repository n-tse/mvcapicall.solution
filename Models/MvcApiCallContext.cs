using Microsoft.EntityFrameworkCore;

namespace MvcApiCall.Models
{
  public class MvcApiCallContext : DbContext
  {
    // public DbSet<Category> Categories { get; set; }
    // public DbSet<Item> Items { get; set; }
    // public DbSet<CategoryItem> CategoryItem { get; set; }

    public MvcApiCallContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}