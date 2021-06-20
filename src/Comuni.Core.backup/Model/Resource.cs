using System.Drawing;
using System.Linq;

namespace Comuni.Core.Model
{
    public class Resource
    {
        private const string AnyName = "Cualquiera";
        private const string GoldLiteral = "Oro";
        private const string ArmyLiteral = "Ejército";
        private const string CrafstmanLiteral = "Artesano";
        private const string PilgrimLiteral = "Peregrino";

        public static Resource Any => new Resource(AnyName, Color.Transparent);
        public static Resource Oro => new Resource(GoldLiteral, Color.Gold);
        public static Resource Army => new Resource(ArmyLiteral, Color.Black);
        public static Resource Craftsman => new Resource(CrafstmanLiteral, Color.White);
        public static Resource Pilgrim => new Resource(PilgrimLiteral, Color.SaddleBrown);
        public static Resource Create(ResourceType tipo)
        {
            if (tipo == ResourceType.Gold) return Oro;
            if (tipo == ResourceType.Army) return Army;
            if (tipo == ResourceType.Craftsman) return Craftsman;
            if (tipo == ResourceType.Pilgrim) return Pilgrim;
            return Any;
        }

        public string Name { get; }
        public Color Color { get; }

        private Resource(string nombre, Color color)
        {
            Name = nombre;
            Color = color;
        }

        public bool IsConcreteColor => !IsAny;
        public bool IsAny => Name.Equals(AnyName);
        public bool IsGold => Name.Equals(GoldLiteral);
        public bool IsArmy => Name.Equals(ArmyLiteral);
        public bool IsCraftsman => Name.Equals(CrafstmanLiteral);
        public bool IsPilgrim => Name.Equals(PilgrimLiteral);

        public ResourceType GetResourceType
        {
            get
            {
                if (IsGold) return ResourceType.Gold;
                if (IsArmy) return ResourceType.Army;
                if (IsCraftsman) return ResourceType.Craftsman;
                if (IsPilgrim) return ResourceType.Pilgrim;
                return ResourceType.Any;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return Name.Equals(((Resource)obj).Name);
        }

        public override int GetHashCode() => Name.GetHashCode();
        public override string ToString() => Name;
    }


}
