using System.Collections.Generic;

namespace Comuni.Core.Model
{
    public class ProjectColumn
    {
        public ProjectColumn First => new ProjectColumn(1, 2, false);
        public ProjectColumn Second => new ProjectColumn(2, 3, false);
        public ProjectColumn Third => new ProjectColumn(3, 2, false);
        public ProjectColumn Fourth => new ProjectColumn(4, 1, true);
        public ProjectColumn Fifth => new ProjectColumn(5, 1, true, 3);
        public ProjectColumn Sixth => new ProjectColumn(6, 2, false, 4);
        public ProjectColumn Seventh => new ProjectColumn(7, 3, false, 5);

        public int Index { get; }
        public int TotalPlaces { get; }
        public IEnumerable<Edificio> Buildings { get; private set; }
        public bool GivesExtraResource { get; }
        public int TotalMaxPlayer { get; }
        public Bid Bid { get; private set; }

        private ProjectColumn(int index, int totalPlaces, bool givesExtraResource, int totalMaxPlayer = 0)
        {
            Index = index;
            TotalPlaces = totalPlaces;
            GivesExtraResource = givesExtraResource;
            TotalMaxPlayer = totalMaxPlayer;
            Bid = null;
            Buildings = new List<Edificio>();
        }

        public bool CanBid(Player player, int gold)
        {
            if (player.Gold < gold)
                return false;

            if (player.Envoys <= 0)
                return false;

            if (Bid != null)
            {
                if (Bid.Jugador.Equals(player))
                    return false;

                if (!Bid.EsSuperada(gold))
                    return false;
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return ((ProjectColumn)obj).Index == Index;
        }
        public override int GetHashCode() => Index.GetHashCode();
    }
}
