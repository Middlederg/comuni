namespace Comuni.Core.Model
{
    public static class EdificiosMilitaresFactory
    {
        public static EdificioBuilder Herreria => new EdificioBuilder(1, "Herrería").SetMilitar();
        public static EdificioBuilder Cuartel => new EdificioBuilder(2, "Cuartel").SetMilitar();
        public static EdificioBuilder Castillo => new EdificioBuilder(3, "Castillo").SetMilitar();
        public static EdificioBuilder Fortaleza => new EdificioBuilder(4, "Fortaleza").SetMilitar();
    }


}
