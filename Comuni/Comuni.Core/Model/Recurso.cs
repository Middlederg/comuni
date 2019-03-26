using System.Drawing;
using System.Linq;

namespace Comuni.Core.Model
{
    public class Recurso
    {
        private const string AnyName = "Cualquiera";
        private const string Gold = "Oro";
        private const string Army = "Ejército";
        private const string Crafstman = "Artesano";
        private const string Pilgrim = "Peregrino";

        public static Recurso Any => new Recurso(AnyName, Color.Transparent);
        public static Recurso Oro => new Recurso(Gold, Color.Gold);
        public static Recurso Ejercito => new Recurso(Army, Color.Black);
        public static Recurso Artesano => new Recurso(Crafstman, Color.White);
        public static Recurso Peregrino => new Recurso(Pilgrim, Color.SaddleBrown);
        public static Recurso Create(TipoRecurso tipo)
        {
            if (tipo == TipoRecurso.Gold) return Oro;
            if (tipo == TipoRecurso.Army) return Ejercito;
            if (tipo == TipoRecurso.Craftsman) return Artesano;
            if (tipo == TipoRecurso.Pilgrim) return Peregrino;
            return Any;
        }

        public string Nombre { get; }
        public Color Color { get; }

        private Recurso(string nombre, Color color)
        {
            Nombre = nombre;
            Color = color;
        }

        public bool IsConcreteColor => !IsAny;
        public bool IsAny => Nombre.Equals(AnyName);
        public bool IsGold => Nombre.Equals(Gold);
        public bool IsArmy => Nombre.Equals(Army);
        public bool IsCraftsman => Nombre.Equals(Crafstman);
        public bool IsPilgrim => Nombre.Equals(Pilgrim);

        public TipoRecurso GetTipoRecurso
        {
            get
            {
                if (IsGold) return TipoRecurso.Gold;
                if (IsArmy) return TipoRecurso.Army;
                if (IsCraftsman) return TipoRecurso.Craftsman;
                if (IsPilgrim) return TipoRecurso.Pilgrim;
                return TipoRecurso.Any;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return Nombre.Equals(((Recurso)obj).Nombre);
        }

        public override int GetHashCode() => Nombre.GetHashCode();
        public override string ToString() => Nombre;
    }


}
