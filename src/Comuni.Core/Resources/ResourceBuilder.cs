namespace Comuni.Core.Resources;

public class ResourceBuilder
{
    private readonly List<Resource> resourceList;

    public ResourceBuilder()
    {
        resourceList = new List<Resource>();
    }

    public ResourceBuilder AddGold(int quantity)
    {
        EnsureQuantityIsOverZero(quantity);
        resourceList.AddRange(Enumerable.Range(0, quantity).Select(x => ResourceFactory.Gold));
        return this;
    }

    public ResourceBuilder AddArmies(int quantity)
    {
        EnsureQuantityIsOverZero(quantity);
        resourceList.AddRange(Enumerable.Range(0, quantity).Select(x => ResourceFactory.Army));
        return this;
    }

    public ResourceBuilder AddCraftsmen(int quantity)
    {
        EnsureQuantityIsOverZero(quantity);
        resourceList.AddRange(Enumerable.Range(0, quantity).Select(x => ResourceFactory.Craftsman));
        return this;
    }

    public ResourceBuilder AddPilgrims(int quantity)
    {
        EnsureQuantityIsOverZero(quantity);
        resourceList.AddRange(Enumerable.Range(0, quantity).Select(x => ResourceFactory.Pilgrim));
        return this;
    }

    public IEnumerable<Resource> Build() => resourceList;

    private static void EnsureQuantityIsOverZero(int quantity)
    {
        if (quantity <= 0)
        {
            throw new ArgumentException("Quantity must be greater than 0");
        }
    }
}
