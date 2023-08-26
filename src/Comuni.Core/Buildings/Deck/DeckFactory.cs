namespace Comuni.Core.Buildings.Deck;

public static class DeckFactory
{
    private static IEnumerable<Building> GetAllBuildings()
    {
        foreach (IDeckFactory factory in new List<IDeckFactory>() { new DeckA(), new DeckB(), new DeckC(), new DeckD() })
        {
            foreach (Building edificio in factory.Create())
            {
                yield return edificio;
            }
        }
    }

    public static IEnumerable<Building> GetAll3PlayerBuildings()
    {
        return GetAllBuildings()
            .Where(x => x.TotalMaxPlayers <= 3)
            .ToList();
    }

    public static IEnumerable<Building> GetAll4PlayerBuildings()
    {
        return GetAllBuildings()
            .Where(x => x.TotalMaxPlayers <= 4)
            .ToList();
    }

    public static IEnumerable<Building> GetAll5PlayerBuildings()
    {
        return GetAllBuildings()
            .Where(x => x.TotalMaxPlayers <= 5)
            .ToList();
    }
}
