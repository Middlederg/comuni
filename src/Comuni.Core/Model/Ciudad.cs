using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Comuni.Core.Model
{
    public class Ciudad
    {
        public static Ciudad Luca => new Ciudad(1, "Luca", Color.DeepSkyBlue, Recurso.Peregrino, Recurso.Any);
        public static Ciudad Firenze => new Ciudad(2, "Firenze", Color.Purple, Recurso.Artesano, Recurso.Any);
        public static Ciudad Siena => new Ciudad(3, "Bologna", Color.ForestGreen, Recurso.Ejercito, Recurso.Any);
        public static Ciudad Bologna => new Ciudad(4, "Siena", Color.Red, Recurso.Oro, Recurso.Any);
        public static Ciudad Milano => new Ciudad(5, "Milano", Color.Orange, Recurso.Any, Recurso.Any);

        public int Numero { get; }
        public string Nombre { get; }
        public Color Color { get; }
        public IEnumerable<Recurso> IngresosBasicos { get; }

        private Ciudad(int numero, string nombre, Color color, params Recurso[] ingresosBasicos)
        {
            Numero = numero;
            Nombre = nombre;
            Color = color;
            IngresosBasicos = ingresosBasicos;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return Numero == ((Ciudad)obj).Numero;
        }

        public override int GetHashCode() => Numero.GetHashCode();
        public override string ToString() => $"{Numero} - {Nombre}";
    }
}
