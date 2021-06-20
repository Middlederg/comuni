namespace Comuni.Core
{
    public static class CulturalBuildingFactory
    {
        public static DeckBuilder Workshop => new DeckBuilder(1, "Taller").SetCultural();
        public static DeckBuilder Library => new DeckBuilder(2, "Biblioteca").SetCultural();
        public static DeckBuilder University => new DeckBuilder(3, "Universidad").SetCultural();
        public static DeckBuilder Theatre => new DeckBuilder(4, "Teatro").SetCultural();
    }
}
