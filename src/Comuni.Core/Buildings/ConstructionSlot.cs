using System.Collections.Generic;
using System.Linq;

namespace Comuni.Core
{
    public class ConstructionSlot
    {
        public List<BuildingCard> Buildings { get; }
        public BuildingType Type { get; }
        public bool IsWall => Type.IsWall;

        public int CurrentLevel => Buildings.Count;
        public bool IsFull => CurrentLevel == 4;
        public int CurrentPoints
        {
            get
            {
                if (IsWall)
                {
                    return 0;
                }
                return Buildings.Select((x, index) => index + 1).Sum();
            }
        }

        public ConstructionSlot(BuildingType type)
        {
            Type = type;
            Buildings = new List<BuildingCard>();
        }

        public bool CanBePlaced(BuildingCard card)
        {
            if (IsWall)
            {
                return !IsFull;
            }
            return card.IsFromType(Type) && !IsFull;
        }

        public int Cost(BuildingCard card, bool isFirstTurn)
        {
            int baseCost = isFirstTurn ? 0 : 1;
            return System.Math.Max(CurrentLevel + 1 - card.Level, 0) + baseCost;
        }

        public void Place(BuildingCard card)
        {
            if (!CanBePlaced(card))
            {
                throw new DomainException($"Card {card} can not be placed in slot {this}");
            }
            Buildings.Add(card);
        }

        public override string ToString() => CurrentLevel.ToString();
    }
}
