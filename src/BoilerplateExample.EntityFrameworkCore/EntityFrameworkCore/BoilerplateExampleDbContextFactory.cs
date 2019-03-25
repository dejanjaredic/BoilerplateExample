using BoilerplateExample.Configuration;
using BoilerplateExample.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BoilerplateExample.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class BoilerplateExampleDbContextFactory : IDesignTimeDbContextFactory<BoilerplateExampleDbContext>
    {
        public BoilerplateExampleDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BoilerplateExampleDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(BoilerplateExampleConsts.ConnectionStringName)
            );

            return new BoilerplateExampleDbContext(builder.Options);
        }
    }
}