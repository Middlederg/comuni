namespace Comuni.Core
{
    public static class GenericBuildingFactory
    {
        public static DeckBuilder Generic(int level) => new DeckBuilder(level, "Consistorio").
            SetEconomic().SetMilitary().SetCultural().SetReligious();
    }


}
