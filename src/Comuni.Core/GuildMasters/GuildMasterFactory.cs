using Comuni.Core.Buildings;
using Comuni.Core.Resources;

namespace Comuni.Core.GuildMasters;

public class GuildMasterFactory
{
    public static GuildMaster Moneylender => new("Prestamista",
        BuildingTypeFactory.Economic, ResourceFactory.Gold);
    public static GuildMaster Captain => new("Capitán",
        BuildingTypeFactory.Military, ResourceFactory.Army);
    public static GuildMaster Architect => new("Arquitecto",
        BuildingTypeFactory.Cultural, ResourceFactory.Craftsman);
    public static GuildMaster Bishop => new("Obispo",
        BuildingTypeFactory.Religious, ResourceFactory.Pilgrim);
}
