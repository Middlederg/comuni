using System.Collections.Generic;

namespace Comuni.Core
{
    public interface IDeckFactory
    {
        IEnumerable<BuildingCard> Create();
    }


}
