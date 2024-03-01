using Volo.Abp.Modularity;

namespace Main;

/* Inherit from this class for your domain layer tests. */
public abstract class MainDomainTestBase<TStartupModule> : MainTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
