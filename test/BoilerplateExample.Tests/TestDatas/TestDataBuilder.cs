using BoilerplateExample.EntityFrameworkCore;

namespace BoilerplateExample.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly BoilerplateExampleDbContext _context;

        public TestDataBuilder(BoilerplateExampleDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}