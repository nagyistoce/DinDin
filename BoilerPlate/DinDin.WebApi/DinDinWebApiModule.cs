using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace DinDin
{
    [DependsOn(typeof(AbpWebApiModule), typeof(DinDinApplicationModule))]
    public class DinDinWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(DinDinApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
