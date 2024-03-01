using Volo.Abp.Modularity;

namespace Main;

public abstract class MainApplicationTestBase<TStartupModule> : MainTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
