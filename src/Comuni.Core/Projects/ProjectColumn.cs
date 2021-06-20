using System.Collections.Generic;

namespace Comuni.Core
{

    public class ProjectColumn :Identity<int>
    {
        public override int Id { get; }
        public int TotalPlaces { get; }
        public bool GivesExtraResource { get; }
        public int TotalMaxPlayer { get; }

        public IEnumerable<BuildingCard> Buildings { get; private set; }
        public Bid Bid { get; private set; }

        internal ProjectColumn(int index, int totalPlaces, bool givesExtraResource, int totalMaxPlayer = 0)
        {
            Id = index;
            TotalPlaces = totalPlaces;
            GivesExtraResource = givesExtraResource;
            TotalMaxPlayer = totalMaxPlayer;
            Bid = null;
            Buildings = new List<BuildingCard>();
        }

        public bool PlayerCanPlaceBid(Player player, int gold)
        {
            if (player.Envoys <= 0)
            {
                return false;
            }

            if (player.Resources.Gold < gold)
            {
                return false;
            }

            if (Bid != null)
            {
                if (Bid.Player == player)
                {
                    return false;
                }

                if (!Bid.CanBeOvercomed(gold))
                {
                    return false;
                }
            }
            return true;
        }


    }
}
