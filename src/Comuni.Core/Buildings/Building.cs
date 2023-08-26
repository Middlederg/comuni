using Comuni.Core.Invasions;

using System.Drawing;

namespace Comuni.Core.Buildings;

public class Building : Identity<Guid>
{
    public static Color BackgroundGenericColor = Color.Beige;
    public static Color ResourceGenericColor = Color.Gray;

    public static Building Create(int level, string name)
    {
        return new(level, name);
    }

    private readonly string name;
    private readonly List<BuildingType> buildingTypesAllowed;
    public BuildingType FirstType => buildingTypesAllowed.First();

    public int Level { get; }
    public InvasionDeck Deck { get; internal set; }
    public int TotalMaxPlayers { get; internal set; }

    private Building(int nivel, string nombre) : base(Guid.NewGuid())
    {
        Level = nivel;
        name = nombre;
        TotalMaxPlayers = 0;
        buildingTypesAllowed = new List<BuildingType>();
    }

    internal void AddType(BuildingType tipo)
    {
        buildingTypesAllowed.Add(tipo);
    }

    public bool IsFromType(BuildingType tipo)
    {
        return buildingTypesAllowed.Any(tipo.Equals);
    }

    public bool IsGeneric => buildingTypesAllowed.Count() > 1;

    public Color GetBackColor => IsGeneric ? BackgroundGenericColor : buildingTypesAllowed.First().Color;
    public Color GetBorderColor => IsGeneric ? ResourceGenericColor : buildingTypesAllowed.First().GetBorder;
    public override string ToString()
    {
        return name;
    }
}
