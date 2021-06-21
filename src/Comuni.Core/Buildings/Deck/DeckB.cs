using System.Collections.Generic;

namespace Comuni.Core
{
    internal class DeckB : IDeckFactory
    {
        public IEnumerable<Building> Create()
        {
            yield return EconomicBuildingFactory.Farm.SetDeckB().Building;
            yield return EconomicBuildingFactory.Market.SetDeckB().Building;
            yield return EconomicBuildingFactory.Mill.SetDeckB().Set4AsTotalMaxPlayers().Building;
            yield return EconomicBuildingFactory.UrbanCentre.SetDeckB().Building;

            yield return MilitaryBuildingFactory.Smithy.SetDeckB().Building;
            yield return MilitaryBuildingFactory.Barracks.SetDeckB().Building;
            yield return MilitaryBuildingFactory.Castle.SetDeckB().Set4AsTotalMaxPlayers().Building;
            yield return MilitaryBuildingFactory.Fortress.SetDeckB().Building;

            yield return CulturalBuildingFactory.Workshop.SetDeckB().Set5AsTotalMaxPlayers().Building;
            yield return CulturalBuildingFactory.Library.SetDeckB().Building;
            yield return CulturalBuildingFactory.University.SetDeckB().Building;
            yield return CulturalBuildingFactory.Theatre.SetDeckB().Set3AsTotalMaxPlayers().Building;

            yield return ReligousBuildingFactory.Chapell.SetDeckB().Set5AsTotalMaxPlayers().Building;
            yield return ReligousBuildingFactory.Church.SetDeckB().Building;
            yield return ReligousBuildingFactory.Monastery.SetDeckB().Building;
            yield return ReligousBuildingFactory.Cathedral.SetDeckB().Set3AsTotalMaxPlayers().Building;

            yield return GenericBuildingFactory.Generic(2).SetDeckB().Set3AsTotalMaxPlayers().Building;
            yield return GenericBuildingFactory.Generic(3).SetDeckB().Building;
        }
    }


}
