using Main.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Main.Blazor;

public abstract class MainComponentBase : AbpComponentBase
{
    protected MainComponentBase()
    {
        LocalizationResource = typeof(MainResource);
    }
}
