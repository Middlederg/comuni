using System.Collections.Generic;

namespace Comuni.Core.Model
{
    public class Juego
    {
        public List<Jugador> Jugadores { get; }
        public List<Proyecto> Proyectos { get; }

        public List<Edificio> Mazos { get; }
        public List<Invasion> Invasiones { get; }
    }
}
