using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace BoilerplateExample.EntityFrameworkCore
{
    [DependsOn(
        typeof(BoilerplateExampleCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class BoilerplateExampleEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerplateExampleEntityFrameworkCoreModule).GetAssembly());
        }
    }
}