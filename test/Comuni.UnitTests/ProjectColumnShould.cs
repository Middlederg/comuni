using System;
using Xunit;
using Comuni.Core;
using FluentAssertions;
using Comuni.Core.Players;
using Comuni.Core.Projects;

namespace Comuni.UnitTests
{
    public class ProjectColumnShould
    {
        private Player playerWith2Gold;
        private Player playerWith3Gold;

        public ProjectColumnShould()
        {
            playerWith2Gold = new Player(CityFactory.Milano);
            playerWith3Gold = new Player(CityFactory.Bologna);
        }

        [Fact]
        public void Allow_to_bid()
        {
            var column = ProjectColumnFactory.First;
            column.BidCanBePlaced(playerWith2Gold, 1).Should().BeTrue();
        }

        [Fact]
        public void Not_Allow_to_bid_when_player_is_out_of_envoys()
        {
            var column = ProjectColumnFactory.First;
            playerWith2Gold.TakeEnvoy();
            playerWith2Gold.TakeEnvoy();
            playerWith2Gold.TakeEnvoy();

            column.BidCanBePlaced(playerWith2Gold, 1).Should().BeFalse();
        }

        [Fact]
        public void Not_Allow_to_bid_when_is_same_player()
        {
            var column = ProjectColumnFactory.First;
            column.PlaceBid(playerWith2Gold, 1);
            column.BidCanBePlaced(playerWith2Gold, 1).Should().BeFalse();
            Action func = () => column.PlaceBid(playerWith2Gold, 1);
            func.Should().Throw<DomainException>();
        }

        [Fact]
        public void Not_Allow_to_bid_when_player_is_out_of_gold()
        {
            var column = ProjectColumnFactory.First;
            column.PlaceBid(playerWith3Gold, 2);
            column.BidCanBePlaced(playerWith2Gold, 3).Should().BeFalse();
            Action func = () => column.PlaceBid(playerWith2Gold, 3);
            func.Should().Throw<DomainException>();
        }

        [Fact]
        public void Not_Allow_to_bid_when_gold_is_lower_than_previous_bid()
        {
            var column = ProjectColumnFactory.First;
            column.PlaceBid(playerWith3Gold, 2);
            column.BidCanBePlaced(playerWith2Gold, 1).Should().BeFalse();
            Action func = () => column.PlaceBid(playerWith2Gold, 1);
            func.Should().Throw<DomainException>();
        }
    }
}
