using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerplateExample.Localization;

namespace BoilerplateExample
{
    public class BoilerplateExampleCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            BoilerplateExampleLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerplateExampleCoreModule).GetAssembly());
        }
    }
}