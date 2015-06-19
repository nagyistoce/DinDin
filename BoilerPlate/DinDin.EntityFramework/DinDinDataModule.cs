using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using DinDin.EntityFramework;

namespace DinDin
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(DinDinCoreModule))]
    public class DinDinDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<DinDinDbContext>(null);
        }
    }
}
