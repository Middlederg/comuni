namespace Comuni.Core.Buildings.Deck;

public interface IDeckFactory
{
    IEnumerable<Building> Create();
}
