namespace Comuni.Core
{
    public class Bid
    {
        public Player Player { get; }
        public int Gold { get; }

        public Bid(Player player, int gold)
        {
            Player = player;
            Gold = gold;
        }

        public bool CanBeOvercomed(int oro) => oro > Gold;
    }
}
