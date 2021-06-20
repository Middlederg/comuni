namespace Comuni.Core
{
    public class GuildMasterFactory
    {
        public static GuildMaster Moneylender => new GuildMaster("Prestamista", ResourceFactory.Gold);
        public static GuildMaster Captain => new GuildMaster("Capitán", ResourceFactory.Army);
        public static GuildMaster Architect => new GuildMaster("Arquitecto", ResourceFactory.Craftsman);
        public static GuildMaster Bishop => new GuildMaster("Obispo", ResourceFactory.Pilgrim);
    }


}
