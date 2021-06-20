using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Comuni.Core.Model
{
    public class City
    {
        public static City Luca => new City(1, "Luca", Color.DeepSkyBlue, Resource.Pilgrim, Resource.Any);
        public static City Firenze => new City(2, "Firenze", Color.Purple, Resource.Craftsman, Resource.Any);
        public static City Siena => new City(3, "Bologna", Color.ForestGreen, Resource.Army, Resource.Any);
        public static City Bologna => new City(4, "Siena", Color.Red, Resource.Oro, Resource.Any);
        public static City Milano => new City(5, "Milano", Color.Orange, Resource.Any, Resource.Any);

        public int Number { get; }
        public string Name { get; }
        public Color Color { get; }
        public IEnumerable<Resource> BasicIncome { get; }

        private City(int numero, string nombre, Color color, params Resource[] basicIncome)
        {
            Number = numero;
            Name = nombre;
            Color = color;
            BasicIncome = basicIncome;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return Number == ((City)obj).Number;
        }

        public override int GetHashCode() => Number.GetHashCode();
        public override string ToString() => $"{Number} - {Name}";
    }
}
