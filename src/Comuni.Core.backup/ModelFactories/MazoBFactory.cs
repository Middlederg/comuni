using System.Collections.Generic;

namespace Comuni.Core.Model
{
    internal class MazoBFactory : IEdificioFactory
    {
        public IEnumerable<Edificio> Create()
        {
            yield return EdificiosEconomicosFactory.Granja.SetLetraB().Edificio;
            yield return EdificiosEconomicosFactory.Mercado.SetLetraB().Edificio;
            yield return EdificiosEconomicosFactory.Molino.SetLetraB().SetNumeroMaximo4().Edificio;
            yield return EdificiosEconomicosFactory.CentroUrbano.SetLetraB().Edificio;

            yield return EdificiosMilitaresFactory.Herreria.SetLetraB().Edificio;
            yield return EdificiosMilitaresFactory.Cuartel.SetLetraB().Edificio;
            yield return EdificiosMilitaresFactory.Castillo.SetLetraB().SetNumeroMaximo4().Edificio;
            yield return EdificiosMilitaresFactory.Fortaleza.SetLetraB().Edificio;

            yield return EdificiosCulturalesFactory.Taller.SetLetraB().SetNumeroMaximo5().Edificio;
            yield return EdificiosCulturalesFactory.Biblioteca.SetLetraB().Edificio;
            yield return EdificiosCulturalesFactory.Universidad.SetLetraB().Edificio;
            yield return EdificiosCulturalesFactory.Teatro.SetLetraB().SetNumeroMaximo3().Edificio;

            yield return EdificiosReligiososFactory.Capilla.SetLetraB().SetNumeroMaximo5().Edificio;
            yield return EdificiosReligiososFactory.Iglesia.SetLetraB().Edificio;
            yield return EdificiosReligiososFactory.Monasterio.SetLetraB().Edificio;
            yield return EdificiosReligiososFactory.Catedral.SetLetraB().SetNumeroMaximo3().Edificio;

            yield return EdificiosGenericosFactory.Generico(2).SetLetraB().SetNumeroMaximo3().Edificio;
            yield return EdificiosGenericosFactory.Generico(3).SetLetraB().Edificio;
        }
    }


}
