using Comuni.Core.Resources;

namespace Comuni.Core.Players;

public class Resources
{
    private readonly List<Resource> resourceList;

    public int Gold => resourceList.Count(x => x.IsGold);
    public int Armies => resourceList.Count(x => x.IsArmy);
    public int Craftsmans => resourceList.Count(x => x.IsCraftsman);
    public int Pilgrims => resourceList.Count(x => x.IsPilgrim);
    public int OfType(Resource resource) => resourceList.Count(x => x.Equals(resource));

    public Resources(City city)
    {
        resourceList = city.InitialResources.ToList();
    }

    public void Add(IEnumerable<Resource> resources) => resourceList.AddRange(resources);

    public void PayCraftsmen(int count) => Pay(ResourceFactory.Craftsman, count);
    public void Pay(Resource resource, int count)
    {
        if (count > resourceList.Count(x => x == resource))
            throw new DomainException($"Can not be paid {count} {resource}");

        foreach (var _ in Enumerable.Range(0, count))
        {
            resourceList.Remove(resource);
        }
    }
}
