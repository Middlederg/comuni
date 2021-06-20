namespace Comuni.Core.Model
{
    public static class EdificiosReligiososFactory
    {
        public static EdificioBuilder Capilla => new EdificioBuilder(1, "Capilla").SetReligioso();
        public static EdificioBuilder Iglesia => new EdificioBuilder(2, "Iglesia").SetReligioso();
        public static EdificioBuilder Monasterio => new EdificioBuilder(3, "Monasterio").SetReligioso();
        public static EdificioBuilder Catedral => new EdificioBuilder(4, "Catedral").SetReligioso();
    }


}
