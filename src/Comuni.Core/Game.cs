using System.Collections.Generic;

namespace Comuni.Core
{
    public class Game
    {
        public List<Player> Players { get; }
        public List<ProjectColumn> ProjectColumns { get; }

        public List<BuildingCard> Deck { get; }
        public List<Invasion> Invasions { get; }
    }
}
