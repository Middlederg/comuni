using System.Collections.Generic;

namespace Comuni.Core.Model
{
    internal class MazoAFactory : IEdificioFactory
    {
        public IEnumerable<Edificio> Create()
        {
            yield return EdificiosEconomicosFactory.Granja.SetLetraA().Edificio;
            yield return EdificiosEconomicosFactory.Granja.SetLetraA().Edificio;
            yield return EdificiosEconomicosFactory.Granja.SetLetraA().SetNumeroMaximo4().Edificio;
            yield return EdificiosEconomicosFactory.Granja.SetLetraA().SetNumeroMaximo5().Edificio;
            yield return EdificiosEconomicosFactory.Mercado.SetLetraA().Edificio;
            yield return EdificiosEconomicosFactory.Mercado.SetLetraA().Edificio;
            yield return EdificiosEconomicosFactory.Mercado.SetLetraA().SetNumeroMaximo3().Edificio;
            yield return EdificiosEconomicosFactory.Molino.SetLetraA().SetNumeroMaximo4().Edificio;

            yield return EdificiosMilitaresFactory.Herreria.SetLetraA().Edificio;
            yield return EdificiosMilitaresFactory.Herreria.SetLetraA().Edificio;
            yield return EdificiosMilitaresFactory.Herreria.SetLetraA().SetNumeroMaximo4().Edificio;
            yield return EdificiosMilitaresFactory.Herreria.SetLetraA().SetNumeroMaximo5().Edificio;
            yield return EdificiosMilitaresFactory.Cuartel.SetLetraA().Edificio;
            yield return EdificiosMilitaresFactory.Cuartel.SetLetraA().Edificio;
            yield return EdificiosMilitaresFactory.Cuartel.SetLetraA().SetNumeroMaximo3().Edificio;
            yield return EdificiosMilitaresFactory.Castillo.SetLetraA().Edificio;

            yield return EdificiosCulturalesFactory.Taller.SetLetraA().Edificio;
            yield return EdificiosCulturalesFactory.Taller.SetLetraA().Edificio;
            yield return EdificiosCulturalesFactory.Taller.SetLetraA().SetNumeroMaximo4().Edificio;
            yield return EdificiosCulturalesFactory.Taller.SetLetraA().SetNumeroMaximo5().Edificio;
            yield return EdificiosCulturalesFactory.Biblioteca.SetLetraA().Edificio;
            yield return EdificiosCulturalesFactory.Biblioteca.SetLetraA().Edificio;
            yield return EdificiosCulturalesFactory.Biblioteca.SetLetraA().SetNumeroMaximo3().Edificio;
            yield return EdificiosCulturalesFactory.Universidad.SetLetraA().SetNumeroMaximo4().Edificio;

            yield return EdificiosReligiososFactory.Capilla.SetLetraA().Edificio;
            yield return EdificiosReligiososFactory.Capilla.SetLetraA().Edificio;
            yield return EdificiosReligiososFactory.Capilla.SetLetraA().SetNumeroMaximo3().Edificio;
            yield return EdificiosReligiososFactory.Capilla.SetLetraA().SetNumeroMaximo5().Edificio;
            yield return EdificiosReligiososFactory.Iglesia.SetLetraA().Edificio;
            yield return EdificiosReligiososFactory.Iglesia.SetLetraA().Edificio;
            yield return EdificiosReligiososFactory.Iglesia.SetLetraA().SetNumeroMaximo3().Edificio;
            yield return EdificiosReligiososFactory.Monasterio.SetLetraA().SetNumeroMaximo4().Edificio;
        }
    }


}
