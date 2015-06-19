using Abp.Application.Services;

namespace DinDin
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class DinDinAppServiceBase : ApplicationService
    {
        protected DinDinAppServiceBase()
        {
            LocalizationSourceName = DinDinConsts.LocalizationSourceName;
        }
    }
}