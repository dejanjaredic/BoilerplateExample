using Abp.AspNetCore.Mvc.Views;

namespace BoilerplateExample.Web.Views
{
    public abstract class BoilerplateExampleRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected BoilerplateExampleRazorPage()
        {
            LocalizationSourceName = BoilerplateExampleConsts.LocalizationSourceName;
        }
    }
}
