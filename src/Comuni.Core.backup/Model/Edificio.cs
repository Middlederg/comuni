using FontAwesome.Sharp;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Comuni.Core.Model
{
    public class Edificio
    {
        public const IconChar IconoGenerico = IconChar.Cubes;
        public static Color ColorFondoGenerico = Color.Beige;
        public static Color ColorRecursoGenerico = Color.Gray;

        public static Edificio Create(int nivel, string nombre) => new Edificio(nivel, nombre);

        public int Nivel { get; }
        public string Nombre { get; }
        public InvasionDeck LetraMazo { get; internal set; }
        public List<BuildingType> Tipos { get; private set; }
        public int NumeroMaximoJugadores { get; internal set; }

        private Edificio(int nivel, string nombre)
        {
            Nivel = nivel;
            Nombre = nombre;
            NumeroMaximoJugadores = 0;
            Tipos = new List<BuildingType>();
        }

        internal void AddTipo(BuildingType tipo) => Tipos.Add(tipo);

        public bool ContieneTipo(BuildingType tipo) => Tipos.Any(x => tipo.Equals(x));
        public int Coste(Edificio edificioSobreElqueConstruir) => System.Math.Max((edificioSobreElqueConstruir.Nivel - Nivel), 0);
        public bool EsGenerico => Tipos.Count > 1;

        public IconChar GetIconChar
        {
            get
            {
                if (EsGenerico)
                    return IconoGenerico;
                return Tipos.First().Icon;
            }
        }

        public Color GetBackColor
        {
            get
            {
                if (EsGenerico)
                    return ColorFondoGenerico;
                return Tipos.First().Color;
            }
        }
        public Color GetColorBorde
        {
            get
            {
                if (EsGenerico)
                    return ColorRecursoGenerico;
                return Tipos.First().GetColorBorde;
            }
        }

        public override string ToString() => $"{Nombre}";
    }


}
