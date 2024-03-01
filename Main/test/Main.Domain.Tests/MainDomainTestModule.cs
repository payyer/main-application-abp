using Volo.Abp.Modularity;

namespace Main;

[DependsOn(
    typeof(MainDomainModule),
    typeof(MainTestBaseModule)
)]
public class MainDomainTestModule : AbpModule
{

}
