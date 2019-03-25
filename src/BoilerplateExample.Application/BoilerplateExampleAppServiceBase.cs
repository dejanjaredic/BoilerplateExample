using Abp.Application.Services;

namespace BoilerplateExample
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class BoilerplateExampleAppServiceBase : ApplicationService
    {
        protected BoilerplateExampleAppServiceBase()
        {
            LocalizationSourceName = BoilerplateExampleConsts.LocalizationSourceName;
        }
    }
}