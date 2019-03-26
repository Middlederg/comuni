namespace Comuni.Core.Model
{
    public class Puja
    {
        public Jugador Jugador { get; }
        public int CantidadOro { get; }

        public Puja(Jugador jugador, int oro)
        {
            Jugador = jugador;
            CantidadOro = oro;
        }

        public bool EsSuperada(int oro) => oro > CantidadOro;
    }
}
