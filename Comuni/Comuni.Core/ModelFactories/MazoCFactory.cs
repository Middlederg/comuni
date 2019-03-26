using System.Collections.Generic;

namespace Comuni.Core.Model
{
    internal class MazoCFactory : IEdificioFactory
    {
        public IEnumerable<Edificio> Create()
        {
            yield return EdificiosEconomicosFactory.Granja.SetLetraC().SetNumeroMaximo5().Edificio;
            yield return EdificiosEconomicosFactory.Molino.SetLetraC().Edificio;
            yield return EdificiosEconomicosFactory.CentroUrbano.SetLetraC().SetNumeroMaximo3().Edificio;

            yield return EdificiosMilitaresFactory.Herreria.SetLetraC().SetNumeroMaximo5().Edificio;
            yield return EdificiosMilitaresFactory.Castillo.SetLetraC().Edificio;
            yield return EdificiosMilitaresFactory.Fortaleza.SetLetraC().SetNumeroMaximo3().Edificio;

            yield return EdificiosCulturalesFactory.Taller.SetLetraC().Edificio;
            yield return EdificiosCulturalesFactory.Universidad.SetLetraC().Edificio;
            yield return EdificiosCulturalesFactory.Teatro.SetLetraC().Edificio;

            yield return EdificiosReligiososFactory.Capilla.SetLetraC().Edificio;
            yield return EdificiosReligiososFactory.Monasterio.SetLetraC().Edificio;
            yield return EdificiosReligiososFactory.Catedral.SetLetraC().Edificio;

            yield return EdificiosReligiososFactory.Capilla.SetLetraC().Edificio;
            yield return EdificiosReligiososFactory.Monasterio.SetLetraC().Edificio;
            yield return EdificiosReligiososFactory.Catedral.SetLetraC().Edificio;

            yield return EdificiosGenericosFactory.Generico(2).SetLetraC().Edificio;
            yield return EdificiosGenericosFactory.Generico(2).SetLetraC().SetNumeroMaximo4().Edificio;
            yield return EdificiosGenericosFactory.Generico(2).SetLetraC().SetNumeroMaximo5().Edificio;
            yield return EdificiosGenericosFactory.Generico(3).SetLetraC().SetNumeroMaximo3().Edificio;
            yield return EdificiosGenericosFactory.Generico(3).SetLetraC().SetNumeroMaximo4().Edificio;
            yield return new EdificioBuilder(4, "Taller de armas").SetLetraC().SetMilitar().SetCultural().Edificio;
            yield return new EdificioBuilder(4, "Basílica").SetLetraC().SetEconomico().SetReligioso().Edificio;
        }
    }


}
