namespace Comuni.Core.Invasions;

public class InvasionFactory
{
    public static Invasion Venezia => new(InvasionDeck.A, "Venezia", 4, 2, 1);
    public static Invasion Pope => new(InvasionDeck.B, "The Pope", 8, 3, 1);
    public static Invasion France => new(InvasionDeck.C, "King of France", 4, 4, 2);
    public static Invasion Emperor => new(InvasionDeck.D, "Emperor", 16, 6, 3);
    public static IEnumerable<Invasion> Invasions => new List<Invasion>()
    {
        Venezia,
        Pope,
        France,
        Emperor
    };
}
