using System.Drawing;

namespace Comuni.Core
{
    public class ResourceFactory
    {
        private const string GoldLiteral = "Gold";
        private const string ArmyLiteral = "Army";
        private const string CrafstmanLiteral = "Craftsman";
        private const string PilgrimLiteral = "Pilgrim";

        public static Resource Gold => new Resource(GoldLiteral, Color.Gold);
        public static Resource Army => new Resource(ArmyLiteral, Color.Black);
        public static Resource Craftsman => new Resource(CrafstmanLiteral, Color.White);
        public static Resource Pilgrim => new Resource(PilgrimLiteral, Color.SaddleBrown);
    }
}
