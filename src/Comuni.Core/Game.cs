using Comuni.Core.Buildings;
using Comuni.Core.Invasions;
using Comuni.Core.Players;
using Comuni.Core.Projects;

namespace Comuni.Core;

public class Game
{
    public List<Player> Players { get; }
    public List<ProjectColumn> ProjectColumns { get; }

    public List<Building> Deck { get; }
    public List<Invasion> Invasions { get; }
}
