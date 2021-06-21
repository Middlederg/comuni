namespace Comuni.Core
{
    public class DeckBuilder
    {
        public Building Building { get; private set; }

        public DeckBuilder(int nivel, string nombre)
        {
            Building = Building.Create(nivel, nombre);
        }

        public DeckBuilder SetDeckA()
        {
            Building.Deck = InvasionDeck.A;
            return this;
        }

        public DeckBuilder SetDeckB()
        {
            Building.Deck = InvasionDeck.B;
            return this;
        }

        public DeckBuilder SetDeckC()
        {
            Building.Deck = InvasionDeck.C;
            return this;
        }

        public DeckBuilder SetDeckD()
        {
            Building.Deck = InvasionDeck.D;
            return this;
        }

        public DeckBuilder Set3AsTotalMaxPlayers()
        {
            Building.TotalMaxPlayers = 3;
            return this;
        }

        public DeckBuilder Set4AsTotalMaxPlayers()
        {
            Building.TotalMaxPlayers = 4;
            return this;
        }

        public DeckBuilder Set5AsTotalMaxPlayers()
        {
            Building.TotalMaxPlayers = 5;
            return this;
        }

        public DeckBuilder SetEconomic()
        {
            Building.AddType(BuildingTypeFactory.Economic);
            return this;
        }

        public DeckBuilder SetMilitary()
        {
            Building.AddType(BuildingTypeFactory.Military);
            return this;
        }

        public DeckBuilder SetCultural()
        {
            Building.AddType(BuildingTypeFactory.Cultural);
            return this;
        }

        public DeckBuilder SetReligious()
        {
            Building.AddType(BuildingTypeFactory.Religious);
            return this;
        }
    }


}
