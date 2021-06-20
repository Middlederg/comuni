using System.Drawing;

namespace Comuni.Core
{
    public class BuildingTypeFactory
    {
        public static BuildingType Economic => new BuildingType("Economic", Color.LightYellow, ResourceFactory.Gold);
        public static BuildingType Military => new BuildingType("Military", Color.LightGray, ResourceFactory.Army);
        public static BuildingType Cultural => new BuildingType("Cultural", Color.LightCyan, ResourceFactory.Craftsman);
        public static BuildingType Religious => new BuildingType("Religious", Color.SandyBrown, ResourceFactory.Pilgrim);
        public static BuildingType Walls => new BuildingType("Murallas", Color.Ivory, null);

    }


}
