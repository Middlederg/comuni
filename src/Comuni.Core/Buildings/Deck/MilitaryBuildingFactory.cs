namespace Comuni.Core.Buildings.Deck;

public static class MilitaryBuildingFactory
{
    public static DeckBuilder Smithy => new DeckBuilder(1, "Herrería").SetMilitary();
    public static DeckBuilder Barracks => new DeckBuilder(2, "Cuartel").SetMilitary();
    public static DeckBuilder Castle => new DeckBuilder(3, "Castillo").SetMilitary();
    public static DeckBuilder Fortress => new DeckBuilder(4, "Fortaleza").SetMilitary();
}
