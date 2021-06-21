namespace Comuni.Core
{
    public class GuildMasterFactory
    {
        public static GuildMaster Moneylender => new GuildMaster("Prestamista", 
            BuildingTypeFactory.Economic, ResourceFactory.Gold);
        public static GuildMaster Captain => new GuildMaster("Capitán",
            BuildingTypeFactory.Military, ResourceFactory.Army);
        public static GuildMaster Architect => new GuildMaster("Arquitecto",
            BuildingTypeFactory.Cultural, ResourceFactory.Craftsman);
        public static GuildMaster Bishop => new GuildMaster("Obispo",
            BuildingTypeFactory.Religious, ResourceFactory.Pilgrim);
    }


}
