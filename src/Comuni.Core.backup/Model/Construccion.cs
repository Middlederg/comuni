namespace Comuni.Core.Model
{
    public class Construccion
    {
        public Edificio Edificio { get; }
        public int Columna { get; }
        public BuildingType Tipo { get; }
        public bool EsMuralla => Tipo.EsMuralla;

        public Construccion(Edificio edificio, BuildingType tipo, int columna)
        {
            Edificio = edificio;
            Columna = columna;
            Tipo = tipo;
        }

        public override string ToString()
        {
            var nombreEdificio = EsMuralla ? "Muralla" : Edificio.ToString();
            return $"{nombreEdificio} - Columna {Columna}";
        }
    }
}
