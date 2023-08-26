using Comuni.Core.Buildings;
using Comuni.Core.Resources;

namespace Comuni.Core.GuildMasters;

public record GuildMaster
{
    private readonly string name;

    public BuildingType Type { get; }
    public Resource Reward { get; }

    public GuildMaster(string name, BuildingType type, Resource reward)
    {
        this.name = name;
        Type = type;
        Reward = reward;
    }

    public override string ToString() => name;
}
