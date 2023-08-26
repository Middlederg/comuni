namespace Comuni.Core.Buildings.Deck;

internal class DeckD : IDeckFactory
{
    public IEnumerable<Building> Create()
    {
        yield return EconomicBuildingFactory.Market.SetDeckD().Building;
        yield return EconomicBuildingFactory.Mill.SetDeckD().Building;
        yield return EconomicBuildingFactory.UrbanCentre.SetDeckD().Building;

        yield return MilitaryBuildingFactory.Barracks.SetDeckD().Building;
        yield return MilitaryBuildingFactory.Castle.SetDeckD().Building;
        yield return MilitaryBuildingFactory.Fortress.SetDeckD().Building;

        yield return CulturalBuildingFactory.Library.SetDeckD().Building;
        yield return CulturalBuildingFactory.University.SetDeckD().Building;
        yield return CulturalBuildingFactory.Theatre.SetDeckD().Building;

        yield return ReligousBuildingFactory.Church.SetDeckD().Building;
        yield return ReligousBuildingFactory.Monastery.SetDeckD().Building;
        yield return ReligousBuildingFactory.Cathedral.SetDeckD().Building;

        yield return GenericBuildingFactory.Generic(2).SetDeckD().Set4AsTotalMaxPlayers().Building;
        yield return GenericBuildingFactory.Generic(3).SetDeckD().Set4AsTotalMaxPlayers().Building;
        yield return GenericBuildingFactory.Generic(3).SetDeckD().Set5AsTotalMaxPlayers().Building;
        yield return new DeckBuilder(4, "Palacio").SetDeckD().SetEconomic().SetCultural().Set3AsTotalMaxPlayers().Building;
        yield return new DeckBuilder(4, "Templo de la orden").SetDeckD().SetMilitary().SetReligious().Set3AsTotalMaxPlayers().Building;
        yield return new DeckBuilder(4, "Seminario").SetDeckD().SetReligious().SetCultural().Set5AsTotalMaxPlayers().Building;
        yield return new DeckBuilder(4, "Ciudadela").SetDeckD().SetEconomic().SetMilitary().Set5AsTotalMaxPlayers().Building;
    }
}
