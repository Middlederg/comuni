using System.Collections.Generic;

namespace Comuni.Core.Model
{
    public interface IEdificioFactory
    {
        IEnumerable<Edificio> Create();
    }


}
