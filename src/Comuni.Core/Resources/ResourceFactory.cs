using System.Drawing;

namespace Comuni.Core.Resources;

public class ResourceFactory
{
    public static Resource Gold => new("Gold", Color.Gold);
    public static Resource Army => new("Army", Color.Black);
    public static Resource Craftsman => new("Craftsman", Color.White);
    public static Resource Pilgrim => new("Pilgrim", Color.SaddleBrown);
}
