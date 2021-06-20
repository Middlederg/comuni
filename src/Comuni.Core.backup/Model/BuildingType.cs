using FontAwesome.Sharp;
using System.Drawing;

namespace Comuni.Core.Model
{
    public class BuildingType
    {
        public static BuildingType Economico => new BuildingType("Económico", Color.LightYellow, IconChar.Coins, Resource.Oro);
        public static BuildingType Militar => new BuildingType("Militar", Color.LightGray, IconChar.Gavel, Resource.Army);
        public static BuildingType Cultural => new BuildingType("Cultural", Color.LightCyan, IconChar.FeatherAlt, Resource.Craftsman);
        public static BuildingType Religioso => new BuildingType("Religioso", Color.SandyBrown, IconChar.Church, Resource.Pilgrim);
        public static BuildingType Murallas => new BuildingType("Murallas", Color.Ivory, IconChar.Archway, null);

        public string Nombre { get; }
        public Color Color { get; }
        public IconChar Icon { get; }
        public Resource Recurso { get;}

        private BuildingType(string nombre, Color color, IconChar icon, Resource recurso)
        {
            Nombre = nombre;
            Color = color;
            Icon = icon;
            Recurso = recurso;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return Icon == ((BuildingType)obj).Icon;
        }

        public override int GetHashCode() => Icon.GetHashCode();
        public override string ToString() => Nombre;

        public bool EsEconomico => Recurso != null && Recurso.IsGold;
        public bool EsMilitar => Recurso != null && Recurso.IsArmy;
        public bool EsCultural => Recurso != null && Recurso.IsCraftsman;
        public bool EsReligioso => Recurso != null && Recurso.IsPilgrim;
        public bool EsMuralla => Recurso == null;

        public Color GetColorBorde
        {
            get
            {
                if (EsEconomico) return Color.DarkOrange;
                if (EsCultural) return Color.Thistle;
                if (EsMilitar) return Color.DimGray;
                if (EsMuralla) return Color.DarkGray;
                return Recurso.Color;
            }
        }
    }


}
