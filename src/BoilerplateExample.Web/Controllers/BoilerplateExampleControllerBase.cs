using Abp.AspNetCore.Mvc.Controllers;

namespace BoilerplateExample.Web.Controllers
{
    public abstract class BoilerplateExampleControllerBase: AbpController
    {
        protected BoilerplateExampleControllerBase()
        {
            LocalizationSourceName = BoilerplateExampleConsts.LocalizationSourceName;
        }
    }
}