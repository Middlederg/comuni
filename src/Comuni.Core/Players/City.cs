using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Comuni.Core
{

    public record City
    {
        private readonly string name;

        public int Number { get; }
        public Color Color { get; }
        public IEnumerable<Resource> BasicIncome { get; }
        public IEnumerable<Resource> InitialResources { get; }

        internal City(int number, string name, Color color, 
            IEnumerable<Resource> initialResources,
            params Resource[] basicIncome)
        {
            this.name = name;
            Number = number;
            Color = color;
            InitialResources = initialResources;
            BasicIncome = basicIncome;
        }

        public override string ToString() => name;
    }
}
