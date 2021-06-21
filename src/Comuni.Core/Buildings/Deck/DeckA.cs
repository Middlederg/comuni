using System.Collections.Generic;

namespace Comuni.Core
{
    internal class DeckA : IDeckFactory
    {
        public IEnumerable<Building> Create()
        {
            yield return EconomicBuildingFactory.Farm.SetDeckA().Building;
            yield return EconomicBuildingFactory.Farm.SetDeckA().Building;
            yield return EconomicBuildingFactory.Farm.SetDeckA().Set4AsTotalMaxPlayers().Building;
            yield return EconomicBuildingFactory.Farm.SetDeckA().Set5AsTotalMaxPlayers().Building;
            yield return EconomicBuildingFactory.Market.SetDeckA().Building;
            yield return EconomicBuildingFactory.Market.SetDeckA().Building;
            yield return EconomicBuildingFactory.Market.SetDeckA().Set3AsTotalMaxPlayers().Building;
            yield return EconomicBuildingFactory.Mill.SetDeckA().Set4AsTotalMaxPlayers().Building;

            yield return MilitaryBuildingFactory.Smithy.SetDeckA().Building;
            yield return MilitaryBuildingFactory.Smithy.SetDeckA().Building;
            yield return MilitaryBuildingFactory.Smithy.SetDeckA().Set4AsTotalMaxPlayers().Building;
            yield return MilitaryBuildingFactory.Smithy.SetDeckA().Set5AsTotalMaxPlayers().Building;
            yield return MilitaryBuildingFactory.Barracks.SetDeckA().Building;
            yield return MilitaryBuildingFactory.Barracks.SetDeckA().Building;
            yield return MilitaryBuildingFactory.Barracks.SetDeckA().Set3AsTotalMaxPlayers().Building;
            yield return MilitaryBuildingFactory.Castle.SetDeckA().Building;

            yield return CulturalBuildingFactory.Workshop.SetDeckA().Building;
            yield return CulturalBuildingFactory.Workshop.SetDeckA().Building;
            yield return CulturalBuildingFactory.Workshop.SetDeckA().Set4AsTotalMaxPlayers().Building;
            yield return CulturalBuildingFactory.Workshop.SetDeckA().Set5AsTotalMaxPlayers().Building;
            yield return CulturalBuildingFactory.Library.SetDeckA().Building;
            yield return CulturalBuildingFactory.Library.SetDeckA().Building;
            yield return CulturalBuildingFactory.Library.SetDeckA().Set3AsTotalMaxPlayers().Building;
            yield return CulturalBuildingFactory.University.SetDeckA().Set4AsTotalMaxPlayers().Building;

            yield return ReligousBuildingFactory.Chapell.SetDeckA().Building;
            yield return ReligousBuildingFactory.Chapell.SetDeckA().Building;
            yield return ReligousBuildingFactory.Chapell.SetDeckA().Set3AsTotalMaxPlayers().Building;
            yield return ReligousBuildingFactory.Chapell.SetDeckA().Set5AsTotalMaxPlayers().Building;
            yield return ReligousBuildingFactory.Church.SetDeckA().Building;
            yield return ReligousBuildingFactory.Church.SetDeckA().Building;
            yield return ReligousBuildingFactory.Church.SetDeckA().Set3AsTotalMaxPlayers().Building;
            yield return ReligousBuildingFactory.Monastery.SetDeckA().Set4AsTotalMaxPlayers().Building;
        }
    }


}
