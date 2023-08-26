namespace Comuni.Core.Buildings.Deck;

internal class DeckC : IDeckFactory
{
    public IEnumerable<Building> Create()
    {
        yield return EconomicBuildingFactory.Farm.SetDeckC().Set5AsTotalMaxPlayers().Building;
        yield return EconomicBuildingFactory.Mill.SetDeckC().Building;
        yield return EconomicBuildingFactory.UrbanCentre.SetDeckC().Set3AsTotalMaxPlayers().Building;

        yield return MilitaryBuildingFactory.Smithy.SetDeckC().Set5AsTotalMaxPlayers().Building;
        yield return MilitaryBuildingFactory.Castle.SetDeckC().Building;
        yield return MilitaryBuildingFactory.Fortress.SetDeckC().Set3AsTotalMaxPlayers().Building;

        yield return CulturalBuildingFactory.Workshop.SetDeckC().Building;
        yield return CulturalBuildingFactory.University.SetDeckC().Building;
        yield return CulturalBuildingFactory.Theatre.SetDeckC().Building;

        yield return ReligousBuildingFactory.Chapell.SetDeckC().Building;
        yield return ReligousBuildingFactory.Monastery.SetDeckC().Building;
        yield return ReligousBuildingFactory.Cathedral.SetDeckC().Building;

        yield return ReligousBuildingFactory.Chapell.SetDeckC().Building;
        yield return ReligousBuildingFactory.Monastery.SetDeckC().Building;
        yield return ReligousBuildingFactory.Cathedral.SetDeckC().Building;

        yield return GenericBuildingFactory.Generic(2).SetDeckC().Building;
        yield return GenericBuildingFactory.Generic(2).SetDeckC().Set4AsTotalMaxPlayers().Building;
        yield return GenericBuildingFactory.Generic(2).SetDeckC().Set5AsTotalMaxPlayers().Building;
        yield return GenericBuildingFactory.Generic(3).SetDeckC().Set3AsTotalMaxPlayers().Building;
        yield return GenericBuildingFactory.Generic(3).SetDeckC().Set4AsTotalMaxPlayers().Building;
        yield return new DeckBuilder(4, "Taller de armas").SetDeckC().SetMilitary().SetCultural().Building;
        yield return new DeckBuilder(4, "Basílica").SetDeckC().SetEconomic().SetReligious().Building;
    }
}
