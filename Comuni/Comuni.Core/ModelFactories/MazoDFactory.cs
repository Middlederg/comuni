using System.Collections.Generic;

namespace Comuni.Core.Model
{
    internal class MazoDFactory : IEdificioFactory
    {
        public IEnumerable<Edificio> Create()
        {
            yield return EdificiosEconomicosFactory.Mercado.SetLetraD().Edificio;
            yield return EdificiosEconomicosFactory.Molino.SetLetraD().Edificio;
            yield return EdificiosEconomicosFactory.CentroUrbano.SetLetraD().Edificio;

            yield return EdificiosMilitaresFactory.Cuartel.SetLetraD().Edificio;
            yield return EdificiosMilitaresFactory.Castillo.SetLetraD().Edificio;
            yield return EdificiosMilitaresFactory.Fortaleza.SetLetraD().Edificio;

            yield return EdificiosCulturalesFactory.Biblioteca.SetLetraD().Edificio;
            yield return EdificiosCulturalesFactory.Universidad.SetLetraD().Edificio;
            yield return EdificiosCulturalesFactory.Teatro.SetLetraD().Edificio;

            yield return EdificiosReligiososFactory.Iglesia.SetLetraD().Edificio;
            yield return EdificiosReligiososFactory.Monasterio.SetLetraD().Edificio;
            yield return EdificiosReligiososFactory.Catedral.SetLetraD().Edificio;

            yield return EdificiosGenericosFactory.Generico(2).SetLetraD().SetNumeroMaximo4().Edificio;
            yield return EdificiosGenericosFactory.Generico(3).SetLetraD().SetNumeroMaximo4().Edificio;
            yield return EdificiosGenericosFactory.Generico(3).SetLetraD().SetNumeroMaximo5().Edificio;
            yield return new EdificioBuilder(4, "Palacio").SetLetraD().SetEconomico().SetCultural().SetNumeroMaximo3().Edificio;
            yield return new EdificioBuilder(4, "Templo de la orden").SetLetraD().SetMilitar().SetReligioso().SetNumeroMaximo3().Edificio;
            yield return new EdificioBuilder(4, "Seminario").SetLetraD().SetReligioso().SetCultural().SetNumeroMaximo5().Edificio;
            yield return new EdificioBuilder(4, "Ciudadela").SetLetraD().SetEconomico().SetMilitar().SetNumeroMaximo5().Edificio;
        }
    }


}
