using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerplateExample.Web.Startup;
namespace BoilerplateExample.Web.Tests
{
    [DependsOn(
        typeof(BoilerplateExampleWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class BoilerplateExampleWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerplateExampleWebTestModule).GetAssembly());
        }
    }
}