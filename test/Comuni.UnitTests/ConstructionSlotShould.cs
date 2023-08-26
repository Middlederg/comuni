using Comuni.Core;
using Comuni.Core.Buildings;
using Comuni.Core.Buildings.Deck;

using FluentAssertions;

using Xunit;

namespace Comuni.UnitTests;

public class ConstructionSlotShould
{
    [Fact]
    public void Be_created()
    {
        var slot = new ConstructionSlot(BuildingTypeFactory.Economic);
        slot.CurrentLevel.Should().Be(0);
        slot.CurrentPoints.Should().Be(0);
        slot.Type.IsEconomic.Should().BeTrue();
        slot.IsWall.Should().BeFalse();
    }

    [Fact]
    public void Place_1_card()
    {
        var level1Card = new DeckBuilder(1, "Level 1").SetEconomic().Building;

        var slot = new ConstructionSlot(BuildingTypeFactory.Economic);

        slot.CanBePlaced(level1Card).Should().BeTrue();
        slot.Cost(level1Card, isFirstTurn: true).Should().Be(0);
        slot.Cost(level1Card, isFirstTurn: false).Should().Be(1);
        slot.Place(level1Card);

        slot.CurrentLevel.Should().Be(1);
        slot.CurrentPoints.Should().Be(1);
    }

    [Fact]
    public void Place_2_cards()
    {
        var level1Card = new DeckBuilder(1, "Level 1").SetEconomic().Building;
        var level2Card = new DeckBuilder(2, "Level 2").SetEconomic().Building;

        var slot = new ConstructionSlot(BuildingTypeFactory.Economic);

        slot.CanBePlaced(level1Card).Should().BeTrue();
        slot.Cost(level1Card, isFirstTurn: true).Should().Be(0);
        slot.Cost(level1Card, isFirstTurn: false).Should().Be(1);
        slot.Place(level1Card);

        slot.CurrentLevel.Should().Be(1);
        slot.CurrentPoints.Should().Be(1);

        slot.CanBePlaced(level2Card).Should().BeTrue();
        slot.Cost(level2Card, isFirstTurn: true).Should().Be(0);
        slot.Cost(level2Card, isFirstTurn: false).Should().Be(1);
        slot.Place(level2Card);

        slot.CurrentLevel.Should().Be(2);
        slot.CurrentPoints.Should().Be(3);
    }

    [Fact]
    public void Place_3_cards()
    {
        var level1Card = new DeckBuilder(1, "Level 1").SetEconomic().Building;
        var level2Card = new DeckBuilder(2, "Level 2").SetEconomic().Building;

        var slot = new ConstructionSlot(BuildingTypeFactory.Economic);

        slot.Place(level1Card);
        slot.Place(level2Card);

        slot.CanBePlaced(level2Card).Should().BeTrue();
        slot.Cost(level2Card, isFirstTurn: true).Should().Be(1);
        slot.Cost(level2Card, isFirstTurn: false).Should().Be(2);
        slot.Place(level2Card);

        slot.CurrentLevel.Should().Be(3);
        slot.CurrentPoints.Should().Be(6);
    }

    [Fact]
    public void Place_4_cards()
    {
        var level1Card = new DeckBuilder(1, "Level 1").SetEconomic().Building;
        var level2Card = new DeckBuilder(2, "Level 2").SetEconomic().Building;

        var slot = new ConstructionSlot(BuildingTypeFactory.Economic);

        slot.Place(level1Card);
        slot.Place(level2Card);
        slot.Place(level2Card);

        slot.CanBePlaced(level1Card).Should().BeTrue();
        slot.Cost(level1Card, isFirstTurn: true).Should().Be(3);
        slot.Cost(level1Card, isFirstTurn: false).Should().Be(4);
        slot.Place(level1Card);

        slot.CurrentLevel.Should().Be(4);
        slot.CurrentPoints.Should().Be(10);
    }

    [Fact]
    public void Not_allow_to_place_the_fifth_card()
    {
        var level1Card = new DeckBuilder(1, "Level 1").SetEconomic().Building;
        var level2Card = new DeckBuilder(2, "Level 2").SetEconomic().Building;

        var slot = new ConstructionSlot(BuildingTypeFactory.Economic);

        slot.Place(level1Card);
        slot.Place(level2Card);
        slot.Place(level2Card);
        slot.Place(level1Card);

        slot.CanBePlaced(level1Card).Should().BeFalse();
        Action func = () => slot.Place(level1Card);
        func.Should().Throw<DomainException>();
    }

    [Fact]
    public void Not_allow_to_build_when_are_from_different_types()
    {
        var level1Card = new DeckBuilder(1, "Level 1").SetEconomic().Building;
        var level2Card = new DeckBuilder(2, "Level 2").SetEconomic().Building;

        var slot = new ConstructionSlot(BuildingTypeFactory.Cultural);
        slot.CanBePlaced(level1Card).Should().BeFalse();
        slot.CanBePlaced(level2Card).Should().BeFalse();

        Action func = () => slot.Place(level1Card);
        func.Should().Throw<DomainException>();
    }

    [Fact]
    public void Operate_with_walls()
    {
        var level1Card = new DeckBuilder(1, "Level 1").SetEconomic().Building;
        var level2Card = new DeckBuilder(2, "Level 2").SetEconomic().Building;

        var slot = new ConstructionSlot(BuildingTypeFactory.Walls);
        slot.IsWall.Should().BeTrue();
        slot.CanBePlaced(level1Card).Should().BeTrue();
        slot.Cost(level1Card, isFirstTurn: true).Should().Be(0);
        slot.Cost(level1Card, isFirstTurn: false).Should().Be(1);
        slot.Place(level1Card);

        slot.CurrentLevel.Should().Be(1);
        slot.CurrentPoints.Should().Be(0);

        slot.CanBePlaced(level2Card).Should().BeTrue();
        slot.Cost(level2Card, isFirstTurn: true).Should().Be(0);
        slot.Cost(level2Card, isFirstTurn: false).Should().Be(1);
        slot.Place(level2Card);

        slot.CurrentLevel.Should().Be(2);
        slot.CurrentPoints.Should().Be(0);

        slot.CanBePlaced(level1Card).Should().BeTrue();
        slot.Cost(level1Card, isFirstTurn: true).Should().Be(2);
        slot.Cost(level1Card, isFirstTurn: false).Should().Be(3);
        slot.Place(level1Card);

        slot.CurrentLevel.Should().Be(3);
        slot.CurrentPoints.Should().Be(0);
    }
}
