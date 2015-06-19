using System.Reflection;
using Abp.Modules;

namespace DinDin
{
    public class DinDinCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
