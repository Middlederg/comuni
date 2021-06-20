namespace Comuni.Core.Model
{
    public class Invasion
    {
        public Invasion Venezia => new Invasion(InvasionDeck.A, "Venezia", 4, 2, 1);
        public Invasion Pope => new Invasion(InvasionDeck.A, "El Papado", 4, 3, 1);
        public Invasion France => new Invasion(InvasionDeck.A, "Rey de Francia", 4, 4, 2);
        public Invasion Emperor => new Invasion(InvasionDeck.D, "El emperador", 16, 6, 3);

        public InvasionDeck Deck { get; }
        public string Name { get; }
        public int Strength { get; }
        public int HeroismFirst { get; }
        public int HeroismSecond { get; }
        public bool HasHappened { get; set; }

        private Invasion(InvasionDeck deck, string name, int strength, int heroismFirst, int heroismSecond)
        {
            Deck = deck;
            Name = name;
            Strength = strength;
            HeroismFirst = heroismFirst;
            HeroismSecond = heroismSecond;
            HasHappened = false;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return ((Invasion)obj).Deck == Deck;
        }
        public override int GetHashCode() => Deck.GetHashCode();
    }
}
