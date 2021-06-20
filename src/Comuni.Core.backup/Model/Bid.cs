namespace Comuni.Core.Model
{
    public class Bid
    {
        public Player Jugador { get; }
        public int CantidadOro { get; }

        public Bid(Player jugador, int oro)
        {
            Jugador = jugador;
            CantidadOro = oro;
        }

        public bool EsSuperada(int oro) => oro > CantidadOro;
    }
}
