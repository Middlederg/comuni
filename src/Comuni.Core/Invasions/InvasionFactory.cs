namespace Comuni.Core.Invasions;

public class InvasionFactory
{
    public Invasion Venezia => new(InvasionDeck.A, "Venezia", 4, 2, 1);
    public Invasion Pope => new(InvasionDeck.A, "The Pope", 4, 3, 1);
    public Invasion France => new(InvasionDeck.A, "King of France", 4, 4, 2);
    public Invasion Emperor => new(InvasionDeck.D, "Emperor", 16, 6, 3);
}
