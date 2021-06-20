using System.Collections.Generic;

namespace Comuni.Core.Model
{
    public class Proyecto
    {
        public Proyecto Proyecto1 => new Proyecto(1, 2, false);
        public Proyecto Proyecto2 => new Proyecto(2, 3, false);
        public Proyecto Proyecto3 => new Proyecto(3, 2, false);
        public Proyecto Proyecto4 => new Proyecto(4, 1, true);
        public Proyecto Proyecto5 => new Proyecto(5, 1, true, 3);
        public Proyecto Proyecto6 => new Proyecto(6, 2, false, 4);
        public Proyecto Proyecto7 => new Proyecto(7, 3, false, 5);

        public int Index { get; }
        public int Huecos { get; }
        public IEnumerable<Edificio> Edificios { get; private set; }
        public bool OtorgaRecursoExtra { get; }
        public int NumeroMaximoJugadores { get; }
        public Puja Puja { get; private set; }

        private Proyecto(int index, int huecos, bool otorgaRecursoExtra, int numeroMaximoJugadores = 0)
        {
            Index = index;
            Huecos = huecos;
            OtorgaRecursoExtra = otorgaRecursoExtra;
            NumeroMaximoJugadores = numeroMaximoJugadores;
            Puja = null;
            Edificios = new List<Edificio>();
        }

        public bool PuedePujar(Jugador jugador, int oro)
        {
            if (jugador.Gold < oro)
                return false;

            if (jugador.Emisarios <= 0)
                return false;

            if (Puja != null)
            {
                if (Puja.Jugador.Equals(jugador))
                    return false;

                if (!Puja.EsSuperada(oro))
                    return false;
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return ((Proyecto)obj).Index == Index;
        }
        public override int GetHashCode() => Index.GetHashCode();
    }
}
