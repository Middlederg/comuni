using System.Collections.Generic;

namespace Comuni.Core
{
    public class ProjectColumn : Identity<int>
    {
        public override int Id { get; }
        public int TotalPlaces { get; }
        public bool GivesExtraResource { get; }
        public int TotalMaxPlayer { get; }

        public IEnumerable<BuildingCard> Buildings { get; private set; }

        public Bid Bid { get; private set; }
        public Player PlaceBid(Player player, int gold)
        {
            Player oldPlayer = null;

            if (!BidCanBePlaced(player, gold))
            {
                throw new DomainException("Bid can not be placed");
            }
            if (Bid != null)
            {
                oldPlayer = Bid.Player;
            }
            Bid = new Bid(player, gold);
            player.Resources.Pay(ResourceFactory.Gold, gold);
            return oldPlayer;
        }

        internal ProjectColumn(int index, int totalPlaces, bool givesExtraResource, int totalMaxPlayer = 0)
        {
            Id = index;
            TotalPlaces = totalPlaces;
            GivesExtraResource = givesExtraResource;
            TotalMaxPlayer = totalMaxPlayer;
            Bid = null;
            Buildings = new List<BuildingCard>();
        }

        public bool BidCanBePlaced(Player player, int gold)
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
