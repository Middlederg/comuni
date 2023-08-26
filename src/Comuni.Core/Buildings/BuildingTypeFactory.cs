using Comuni.Core.Resources;

using System.Drawing;

namespace Comuni.Core.Buildings;

public class BuildingTypeFactory
{
    public static BuildingType Economic => new("Economic", Color.LightYellow, ResourceFactory.Gold);
    public static BuildingType Military => new("Military", Color.LightGray, ResourceFactory.Army);
    public static BuildingType Cultural => new("Cultural", Color.LightCyan, ResourceFactory.Craftsman);
    public static BuildingType Religious => new("Religious", Color.SandyBrown, ResourceFactory.Pilgrim);
    public static BuildingType Walls => new("Murallas", Color.Ivory, null);

}
