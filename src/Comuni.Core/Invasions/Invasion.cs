namespace Comuni.Core
{
    public class Invasion : Identity<InvasionDeck>
    {
        private readonly InvasionDeck deck;
        private readonly string name;

        public override InvasionDeck Id => deck;
        public int Strength { get; }
        public int HeroismFirst { get; }
        public int HeroismSecond { get; }

        internal Invasion(InvasionDeck deck, string name, int strength, int heroismFirst, int heroismSecond)
        {
            this.deck = deck;
            this.name = name;
            Strength = strength;
            HeroismFirst = heroismFirst;
            HeroismSecond = heroismSecond;
        }

        public override string ToString() => name;
    }
}
