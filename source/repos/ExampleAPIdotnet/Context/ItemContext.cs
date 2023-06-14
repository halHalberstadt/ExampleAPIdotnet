using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

namespace ExampleAPIdotnet.Context
{

    public class ItemContext : DbContext
    {

        public ItemContext(DbContextOptions<ItemContext> options) : base(options) {
        }

    }

    public class ItemContextFactory : IDesignTimeDbContextFactory<ItemContext>
    {
        public ItemContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ItemContext>();
            optionsBuilder.UseSqlServer("Data Source=Item.db");

            return new ItemContext(optionsBuilder.Options);
        }
    }
}