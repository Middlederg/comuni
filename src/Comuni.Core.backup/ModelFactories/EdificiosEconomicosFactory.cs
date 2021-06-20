namespace Comuni.Core.Model
{
    public static class EdificiosEconomicosFactory
    {
        public static EdificioBuilder Granja => new EdificioBuilder(1, "Granja").SetEconomico();
        public static EdificioBuilder Mercado => new EdificioBuilder(2, "Mercado").SetEconomico();
        public static EdificioBuilder Molino => new EdificioBuilder(3, "Molino").SetEconomico();
        public static EdificioBuilder CentroUrbano => new EdificioBuilder(4, "Centro urbano").SetEconomico();
    }


}
