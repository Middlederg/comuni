using System.Collections.Generic;

namespace Comuni.Core
{
    public class Player : Identity<int>
    {
        public City City { get; }

        public override int Id => City.Number;

        public Resources Resources { get; }
        public IEnumerable<ConstructionSlot> Buildings { get; private set; }
        public int Envoys { get; private set; }
        public void TakeEnvoy() => Envoys = Envoys - 1;

        public Player(City city)
        {
            City = city;
            Resources = new Resources(city);
            Buildings = new List<ConstructionSlot>();
            Envoys = 3;
        }

        public override string ToString() => City.ToString();
    }
}
