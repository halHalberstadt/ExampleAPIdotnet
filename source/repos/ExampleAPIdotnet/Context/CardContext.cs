using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

namespace ExampleAPIdotnet.Context
{

    public class CardContext : DbContext
    {

        public CardContext(DbContextOptions<CardContext> options) : base(options) {
        }

    }

    public class CardContextFactory : IDesignTimeDbContextFactory<CardContext>
    {
        public CardContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CardContext>();
            optionsBuilder.UseSqlServer("Data Source=Card.db");

            return new CardContext(optionsBuilder.Options);
        }
    }
}