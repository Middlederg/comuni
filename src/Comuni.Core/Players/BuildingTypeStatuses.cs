using System.Collections.Generic;
using System.Linq;

namespace Comuni.Core
{
    public class BuildingTypeStatuses
    {
        private readonly IEnumerable<BuildingTypeStatus> buildingTypeStatuses;
        private BuildingTypeStatus OfType(BuildingType type) => buildingTypeStatuses.FirstOrDefault(x => x.Type.Equals(type));

        public bool WouldCollect(BuildingType type) => OfType(type)?.Active ?? false;
        public void Enable(BuildingType type) => OfType(type)?.Activate();
        public void Reset()
        {
            foreach (var status in buildingTypeStatuses)
            {
                status.Reset();
            }
        }

        public BuildingTypeStatuses()
        {
            buildingTypeStatuses = new List<BuildingTypeStatus>()
            {
                new BuildingTypeStatus(BuildingTypeFactory.Economic),
                new BuildingTypeStatus(BuildingTypeFactory.Military),
                new BuildingTypeStatus(BuildingTypeFactory.Cultural),
                new BuildingTypeStatus(BuildingTypeFactory.Religious),
            };
        }

    }
}
