using Xunit;
using Comuni.Core;
using FluentAssertions;
using System.Linq;

namespace Comuni.UnitTests
{
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
            var deck = DeckFactory.GetAll4PlayerBuildings();
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
}
