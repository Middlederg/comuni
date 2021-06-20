using System.Collections.Generic;

namespace Comuni.Core.Model
{
    public class Juego
    {
        public List<Player> Jugadores { get; }
        public List<ProjectColumn> Proyectos { get; }

        public List<Edificio> Mazos { get; }
        public List<Invasion> Invasiones { get; }
    }
}
