using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ElsaProject.Authorization;

namespace ElsaProject
{
    [DependsOn(
        typeof(ElsaProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ElsaProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ElsaProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ElsaProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
