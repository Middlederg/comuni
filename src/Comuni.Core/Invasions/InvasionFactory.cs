namespace Comuni.Core
{
    public class InvasionFactory
    {
        public Invasion Venezia => new Invasion(InvasionDeck.A, "Venezia", 4, 2, 1);
        public Invasion Pope => new Invasion(InvasionDeck.A, "The Pope", 4, 3, 1);
        public Invasion France => new Invasion(InvasionDeck.A, "King of France", 4, 4, 2);
        public Invasion Emperor => new Invasion(InvasionDeck.D, "Emperor", 16, 6, 3);
    }
}
