using Comuni.Core.Buildings;

namespace Comuni.Core.Players;

public class BuildingTypeStatus
{
    public BuildingType Type { get; }
    public bool Active { get; private set; }
    public void Activate()
    {
        Active = true;
    }

    public void Reset()
    {
        Active = false;
    }

    public BuildingTypeStatus(BuildingType type)
    {
        Type = type;
        Active = false;
    }
}
