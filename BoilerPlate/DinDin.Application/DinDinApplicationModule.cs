using System.Reflection;
using Abp.Modules;

namespace DinDin
{
    [DependsOn(typeof(DinDinCoreModule))]
    public class DinDinApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
