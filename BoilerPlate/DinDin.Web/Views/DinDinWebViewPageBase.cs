using Abp.Web.Mvc.Views;

namespace DinDin.Web.Views
{
    public abstract class DinDinWebViewPageBase : DinDinWebViewPageBase<dynamic>
    {

    }

    public abstract class DinDinWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected DinDinWebViewPageBase()
        {
            LocalizationSourceName = DinDinConsts.LocalizationSourceName;
        }
    }
}