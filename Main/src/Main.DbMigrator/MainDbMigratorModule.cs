using Main.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Main.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MainEntityFrameworkCoreModule),
    typeof(MainApplicationContractsModule)
    )]
public class MainDbMigratorModule : AbpModule
{
}
