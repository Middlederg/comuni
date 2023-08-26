using Comuni.Core.Resources;

using System.Drawing;

namespace Comuni.Core.Buildings;

public record BuildingType
{
    private readonly string name;

    public Color Color { get; }
    public Resource Resource { get; }

    internal BuildingType(string name, Color color, Resource recurso)
    {
        this.name = name;
        Color = color;
        Resource = recurso;
    }

    public override string ToString()
    {
        return name;
    }

    public bool IsEconomic => Resource != null && Resource.IsGold;
    public bool IsMilitary => Resource != null && Resource.IsArmy;
    public bool IsCultural => Resource != null && Resource.IsCraftsman;
    public bool IsReligious => Resource != null && Resource.IsPilgrim;
    public bool IsWall => Resource is null;

    public Color GetBorder
    {
        get
        {
            if (IsEconomic) return Color.DarkOrange;
            if (IsCultural) return Color.Thistle;
            if (IsMilitary) return Color.DimGray;
            return IsWall ? Color.DarkGray : Resource.Color;
        }
    }
}
