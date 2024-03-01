using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Main.Blazor;

[Dependency(ReplaceServices = true)]
public class MainBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Main";
}
