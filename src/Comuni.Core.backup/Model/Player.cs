using System.Collections.Generic;
using System.Linq;

namespace Comuni.Core.Model
{
    public class Player
    {
        public City City { get; set; }
        public int Index => City.Number;
        public override string ToString() => City.Name;
        public IEnumerable<Resource> Resources { get; private set; }
        public IEnumerable<Construccion> Buildings { get; private set; }
        public int Envoys { get; set; }

        public int Gold => Resources.Count(x => x.IsGold);
        public int Armies => Resources.Count(x => x.IsArmy);
        public int Craftsmans => Resources.Count(x => x.IsCraftsman);
        public int Pilgrims => Resources.Count(x => x.IsPilgrim);

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return ((Player)obj).Index == Index;
        }
        public override int GetHashCode() => Index.GetHashCode();
    }
}
