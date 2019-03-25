using System;
using System.Threading.Tasks;
using Abp.TestBase;
using BoilerplateExample.EntityFrameworkCore;
using BoilerplateExample.Tests.TestDatas;

namespace BoilerplateExample.Tests
{
    public class BoilerplateExampleTestBase : AbpIntegratedTestBase<BoilerplateExampleTestModule>
    {
        public BoilerplateExampleTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<BoilerplateExampleDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<BoilerplateExampleDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<BoilerplateExampleDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<BoilerplateExampleDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<BoilerplateExampleDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<BoilerplateExampleDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<BoilerplateExampleDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<BoilerplateExampleDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
