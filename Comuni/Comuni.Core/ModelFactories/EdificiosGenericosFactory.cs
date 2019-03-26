namespace Comuni.Core.Model
{
    public static class EdificiosGenericosFactory
    {
        public static EdificioBuilder Generico(int nivel) => new EdificioBuilder(nivel, "Consistorio").
            SetEconomico().SetMilitar().SetCultural().SetReligioso();
    }


}
