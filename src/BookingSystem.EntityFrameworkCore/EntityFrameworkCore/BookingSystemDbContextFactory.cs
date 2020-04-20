using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using BookingSystem.Configuration;
using BookingSystem.Web;

namespace BookingSystem.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class BookingSystemDbContextFactory : IDesignTimeDbContextFactory<BookingSystemDbContext>
    {
        public BookingSystemDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BookingSystemDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            BookingSystemDbContextConfigurer.Configure(builder, configuration.GetConnectionString(BookingSystemConsts.ConnectionStringName));

            return new BookingSystemDbContext(builder.Options);
        }
    }
}
