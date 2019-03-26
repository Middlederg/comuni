using System.Collections.Generic;

namespace Comuni.Core.Model
{
    public static class EdificiosFactory
    {
        public static IEnumerable<Edificio> GenerarEdificios()
        {
            foreach (var factory in new List<IEdificioFactory>() { new MazoAFactory(), new MazoBFactory(), new MazoCFactory(), new MazoDFactory() })
            {
                foreach (var edificio in factory.Create())
                    yield return edificio;
            }
        }
    }


}
