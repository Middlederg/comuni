using System.Drawing;

namespace Comuni.Core.Resources;

public record Resource
{
    private readonly string name;
    public Color Color { get; }

    internal Resource(string nombre, Color color)
    {
        name = nombre;
        Color = color;
    }

    public bool IsGold => this == ResourceFactory.Gold;
    public bool IsArmy => this == ResourceFactory.Army;
    public bool IsCraftsman => this == ResourceFactory.Craftsman;
    public bool IsPilgrim => this == ResourceFactory.Pilgrim;

    public override string ToString() => name;
}
