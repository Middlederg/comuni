using Comuni.Core.Buildings;

namespace Comuni.Core.Players;

public class BuildingTypeStatuses
{
    private readonly IEnumerable<BuildingTypeStatus> buildingTypeStatuses;
    private BuildingTypeStatus OfType(BuildingType type)
    {
        return buildingTypeStatuses.FirstOrDefault(x => x.Type.Equals(type));
    }

    public bool WouldCollect(BuildingType type)
    {
        return OfType(type)?.Active ?? false;
    }

    public void Enable(BuildingType type)
    {
        OfType(type)?.Activate();
    }

    public void Reset()
    {
        foreach (BuildingTypeStatus status in buildingTypeStatuses)
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
