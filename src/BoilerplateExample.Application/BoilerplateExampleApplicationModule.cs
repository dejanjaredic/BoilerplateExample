using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace BoilerplateExample
{
    [DependsOn(
        typeof(BoilerplateExampleCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BoilerplateExampleApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerplateExampleApplicationModule).GetAssembly());
        }
    }
}