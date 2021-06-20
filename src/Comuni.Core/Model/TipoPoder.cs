using FontAwesome.Sharp;
using System.Drawing;

namespace Comuni.Core.Model
{
    public class TipoPoder
    {
        public static TipoPoder Economico => new TipoPoder("Económico", Color.LightYellow, IconChar.Coins, Recurso.Oro);
        public static TipoPoder Militar => new TipoPoder("Militar", Color.LightGray, IconChar.Gavel, Recurso.Ejercito);
        public static TipoPoder Cultural => new TipoPoder("Cultural", Color.LightCyan, IconChar.FeatherAlt, Recurso.Artesano);
        public static TipoPoder Religioso => new TipoPoder("Religioso", Color.SandyBrown, IconChar.Church, Recurso.Peregrino);
        public static TipoPoder Murallas => new TipoPoder("Murallas", Color.Ivory, IconChar.Archway, null);

        public string Nombre { get; }
        public Color Color { get; }
        public IconChar Icon { get; }
        public Recurso Recurso { get;}

        private TipoPoder(string nombre, Color color, IconChar icon, Recurso recurso)
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
            return Icon == ((TipoPoder)obj).Icon;
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
