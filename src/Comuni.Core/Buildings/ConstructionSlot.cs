namespace Comuni.Core.Buildings;

public class ConstructionSlot
{
    public List<Building> Buildings { get; }
    public BuildingType Type { get; }
    public bool IsWall => Type.IsWall;

    public int CurrentLevel => Buildings.Count;
    public bool IsFull => CurrentLevel == 4;
    public int CurrentPoints => IsWall ? 0 : Buildings.Select((x, index) => index + 1).Sum();

    public ConstructionSlot(BuildingType type)
    {
        Type = type;
        Buildings = new List<Building>();
    }

    public bool CanBePlaced(Building card)
    {
        return IsWall ? !IsFull : card.IsFromType(Type) && !IsFull;
    }

    public int Cost(Building card, bool isFirstTurn)
    {
        int baseCost = isFirstTurn ? 0 : 1;
        return Math.Max(CurrentLevel + 1 - card.Level, 0) + baseCost;
    }

    public void Place(Building card)
    {
        if (!CanBePlaced(card))
            throw new DomainException($"Card {card} can not be placed in slot {this}");
        Buildings.Add(card);
    }

    public override string ToString()
    {
        return CurrentLevel.ToString();
    }
}
