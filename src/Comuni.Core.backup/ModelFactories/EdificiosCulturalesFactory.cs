namespace Comuni.Core.Model
{
    public static class EdificiosCulturalesFactory
    {
        public static EdificioBuilder Taller => new EdificioBuilder(1, "Taller").SetCultural();
        public static EdificioBuilder Biblioteca => new EdificioBuilder(2, "Biblioteca").SetCultural();
        public static EdificioBuilder Universidad => new EdificioBuilder(3, "Universidad").SetCultural();
        public static EdificioBuilder Teatro => new EdificioBuilder(4, "Teatro").SetCultural();
    }


}
