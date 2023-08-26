using Comuni.Core.Buildings;
using Comuni.Core.Buildings.Deck;
using Comuni.Core.Invasions;
using Comuni.Core.Players;
using Comuni.Core.Projects;

using System.Numerics;

namespace Comuni.Core;

public class Game
{
    public List<Player> Players { get; }
    public List<ProjectColumn> ProjectColumns { get; }
    public List<Building> Deck { get; }
    public List<Invasion> Invasions { get; }

    public Game()
    {
        Players = new List<Player>() { new Player(CityFactory.Luca) };
        Deck = DeckFactory.GetAll3PlayerBuildings().ToList();
        ProjectColumns = ProjectColumnFactory.Create().ToList();
        Invasions = InvasionFactory.Invasions.ToList();
        
        Draw();
        Draw();
        Draw();
    }

    public Player Player => Players.First();

    private void Draw()
    {
        Player.Hand.Add(Deck.First());
        Deck.RemoveAt(0);
    }
}
