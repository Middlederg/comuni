namespace Comuni.Core.Invasions;

public class Invasion : Identity<InvasionDeck>
{
    private readonly string name;

    public int Strength { get; }
    public int HeroismFirst { get; }
    public int HeroismSecond { get; }

    internal Invasion(InvasionDeck deck, string name, int strength, int heroismFirst, int heroismSecond) : base(deck)
    {
        this.name = name;
        Strength = strength;
        HeroismFirst = heroismFirst;
        HeroismSecond = heroismSecond;
    }

    public override string ToString() => name;
}
