namespace Comuni.Core.Buildings.Deck;

public static class GenericBuildingFactory
{
    public static DeckBuilder Generic(int level)
    {
        return new DeckBuilder(level, "Consistorio").
        SetEconomic().SetMilitary().SetCultural().SetReligious();
    }
}
