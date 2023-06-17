using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

namespace ExampleAPIdotnet.Context
{

    public class UserContext : DbContext
    {

        public UserContext(DbContextOptions<UserContext> options) : base(options) {
        }

    }

    public class UserContextFactory : IDesignTimeDbContextFactory<UserContext>
    {
        public UserContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<UserContext>();
            optionsBuilder.UseSqlServer("Data Source=User.db");

            return new UserContext(optionsBuilder.Options);
        }
    }
}