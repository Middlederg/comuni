using Xunit;
using FluentAssertions;
using Comuni.Core.Resources;

namespace Comuni.UnitTests
{
    public class ResourceShould
    {
        [Fact]
        public void Be_gold()
        {
            var resource = ResourceFactory.Gold;

            resource.IsArmy.Should().BeFalse();
            resource.IsCraftsman.Should().BeFalse();
            resource.IsGold.Should().BeTrue();
            resource.IsPilgrim.Should().BeFalse();
            resource.Should().Be(ResourceFactory.Gold);
        }

        [Fact]
        public void Be_army()
        {
            var resource = ResourceFactory.Army;

            resource.IsArmy.Should().BeTrue();
            resource.IsCraftsman.Should().BeFalse();
            resource.IsGold.Should().BeFalse();
            resource.IsPilgrim.Should().BeFalse();
            resource.Should().Be(ResourceFactory.Army);
        }

        [Fact]
        public void Be_pilgrim()
        {
            var resource = ResourceFactory.Pilgrim;

            resource.IsArmy.Should().BeFalse();
            resource.IsCraftsman.Should().BeFalse();
            resource.IsGold.Should().BeFalse();
            resource.IsPilgrim.Should().BeTrue();
            resource.Should().Be(ResourceFactory.Pilgrim);
        }

        [Fact]
        public void Be_craftsman()
        {
            var resource = ResourceFactory.Craftsman;

            resource.IsArmy.Should().BeFalse();
            resource.IsCraftsman.Should().BeTrue();
            resource.IsGold.Should().BeFalse();
            resource.IsPilgrim.Should().BeFalse();
            resource.Should().Be(ResourceFactory.Craftsman);
        }
    }
}
