using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerplateExample.Configuration;
using BoilerplateExample.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace BoilerplateExample.Web.Startup
{
    [DependsOn(
        typeof(BoilerplateExampleApplicationModule), 
        typeof(BoilerplateExampleEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class BoilerplateExampleWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public BoilerplateExampleWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(BoilerplateExampleConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<BoilerplateExampleNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(BoilerplateExampleApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerplateExampleWebModule).GetAssembly());
        }
    }
}