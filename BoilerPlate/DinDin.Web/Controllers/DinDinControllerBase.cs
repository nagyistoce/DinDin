using Abp.Web.Mvc.Controllers;

namespace DinDin.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class DinDinControllerBase : AbpController
    {
        protected DinDinControllerBase()
        {
            LocalizationSourceName = DinDinConsts.LocalizationSourceName;
        }
    }
}