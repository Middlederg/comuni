namespace Comuni.Core
{
    public static class EconomicBuildingFactory
    {
        public static DeckBuilder Farm => new DeckBuilder(1, "Granja").SetEconomic();
        public static DeckBuilder Market => new DeckBuilder(2, "Mercado").SetEconomic();
        public static DeckBuilder Mill => new DeckBuilder(3, "Molino").SetEconomic();
        public static DeckBuilder UrbanCentre => new DeckBuilder(4, "Centro urbano").SetEconomic();
    }


}
