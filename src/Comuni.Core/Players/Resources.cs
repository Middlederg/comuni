using System.Collections.Generic;
using System.Linq;

namespace Comuni.Core
{
    public class Resources
    {
        private readonly List<Resource> resourceList;

        public int Gold => resourceList.Count(x => x.IsGold);
        public int Armies => resourceList.Count(x => x.IsArmy);
        public int Craftsmans => resourceList.Count(x => x.IsCraftsman);
        public int Pilgrims => resourceList.Count(x => x.IsPilgrim);

        public Resources(City city)
        {
            resourceList = city.InitialResources.ToList();
        }

        public void Add(IEnumerable<Resource> resources) => resourceList.AddRange(resources);
    }
}
