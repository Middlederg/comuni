using System.Collections.Generic;
using System.Linq;

namespace Comuni.Core
{
    public class CardConstructer
    {
        private readonly Player player;

        public bool CanBeBuild(ConstructionSlot slot, BuildingCard card, bool isFirstTurn)
        {
            int cost = isFirstTurn ? 0 : 1;

            cost+= card.
        }
        public void Build(BuildingCard card)
        {

        }
    }

    public class ConstructionSlot
    {
        public List<BuildingCard> Buildings { get; }
        public BuildingType Type { get; }
        public bool IsWall => Type.IsWall;

        public int CurrentLevel => Buildings.Count;
        public int CurrentPoints => Buildings.Select((x, index) => index + 1).Sum();

        public ConstructionSlot(BuildingType type)
        {
            Type = type;
            Buildings = new List<BuildingCard>();
        }

        public bool CanBePlaced(BuildingCard card)
        {
            return card.IsFromType(Type);
        }

        public int Cost(BuildingCard card)
        {
            return System.Math.Max(CurrentLevel - card.Level, 0) + 1;
        }

        public void Place(BuildingCard card)
        {
            if (!CanBePlaced(card))
            {
                throw new CardException($"Card {card} can not be placed in slot {this}");
            }
            Buildings.Add(card);
        }

        public override string ToString() => CurrentLevel.ToString();
    }
}
