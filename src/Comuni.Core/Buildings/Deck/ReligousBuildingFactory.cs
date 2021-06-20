namespace Comuni.Core
{
    public static class ReligousBuildingFactory
    {
        public static DeckBuilder Chapell => new DeckBuilder(1, "Capilla").SetReligious();
        public static DeckBuilder Church => new DeckBuilder(2, "Iglesia").SetReligious();
        public static DeckBuilder Monastery => new DeckBuilder(3, "Monasterio").SetReligious();
        public static DeckBuilder Cathedral => new DeckBuilder(4, "Catedral").SetReligious();
    }


}
