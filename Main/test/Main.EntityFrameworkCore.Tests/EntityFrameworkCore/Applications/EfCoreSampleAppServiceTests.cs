using Main.Samples;
using Xunit;

namespace Main.EntityFrameworkCore.Applications;

[Collection(MainTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MainEntityFrameworkCoreTestModule>
{

}
