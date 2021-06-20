using System;
using Xunit;
using Comuni.Core;
using FluentAssertions;
using System.Linq;

namespace Comuni.UnitTests
{
    public class BuildingCardShould
    {
        [Fact]
        public void Have_cost_of_1()
        {
            var level1Card = new DeckBuilder(1, "Level 1").Building;
            var level2Card = new DeckBuilder(2, "Level 2").Building;

            var cost = level2Card.Cost(level1Card);
            cost.Should().Be(1);
        }

        [Fact]
        public void Have_cost_of_2()
        {
            var level1Card = new DeckBuilder(1, "Level 1").Building;
            var level2Card = new DeckBuilder(2, "Level 2").Building;

            var cost = level1Card.Cost(level2Card);
            cost.Should().Be(1);
        }
    }

    public class DeckShould
    {
        [Fact]
        public void Be_created_for_3_players()
        {
            var deck = DeckFactory.GetAll3PlayerBuildings();
            deck.Should().NotBeEmpty();
            deck.All(x => x.TotalMaxPlayers <= 3).Should().BeTrue();
        }

        [Fact]
        public void Be_created_for_4_players()
        {
            var deck = DeckFactory.GetAll5PlayerBuildings();
            deck.Should().NotBeEmpty();
            deck.All(x => x.TotalMaxPlayers <= 4).Should().BeTrue();
        }

        [Fact]
        public void Be_created_for_5_players()
        {
            var deck = DeckFactory.GetAll5PlayerBuildings();
            deck.Should().NotBeEmpty();
            deck.All(x => x.TotalMaxPlayers <= 5).Should().BeTrue();
        }
    }

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
