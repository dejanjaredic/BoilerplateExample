using Microsoft.EntityFrameworkCore;

namespace BoilerplateExample.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<BoilerplateExampleDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for BoilerplateExampleDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
