using Xunit;

namespace Main.EntityFrameworkCore;

[CollectionDefinition(MainTestConsts.CollectionDefinitionName)]
public class MainEntityFrameworkCoreCollection : ICollectionFixture<MainEntityFrameworkCoreFixture>
{

}
