using Main.Samples;
using Xunit;

namespace Main.EntityFrameworkCore.Domains;

[Collection(MainTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MainEntityFrameworkCoreTestModule>
{

}
