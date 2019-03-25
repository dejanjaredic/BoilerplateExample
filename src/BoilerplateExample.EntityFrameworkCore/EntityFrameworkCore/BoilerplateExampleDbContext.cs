using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BoilerplateExample.EntityFrameworkCore
{
    public class BoilerplateExampleDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Task> Tasks { get; set; }
        public BoilerplateExampleDbContext(DbContextOptions<BoilerplateExampleDbContext> options) 
            : base(options)
        {

        }
    }
}
