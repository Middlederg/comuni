using System.Collections.Generic;
using System.Linq;

namespace Comuni.Core
{
    public class Player : Identity<int>
    {
        public City City { get; }

        public override int Id => City.Number;

        public Resources Resources { get; }
        public Slots Slots { get; }

        public int Envoys { get; private set; }
        public void TakeEnvoy() => Envoys -= 1;
        public IEnumerable<GuildMaster> GuildMasters { get; private set; }
        public GuildMaster GuildMasterOfType(BuildingType type) => GuildMasters.FirstOrDefault(x => x.Type.Equals(type));
        public bool HasGuildMaster(BuildingType type) => GuildMasters.Any(x => x.Type.Equals(type));
        public BuildingTypeStatuses BuildingTypeStatuses { get; }

        public Player(City city)
        {
            City = city;
            Resources = new Resources(city);
            Slots = new Slots();
            GuildMasters = new List<GuildMaster>();
            BuildingTypeStatuses = new BuildingTypeStatuses();
            Envoys = 3;
        }

        public bool CanBuild(ConstructionSlot slot, Building card, bool isFirstTurn)
        {
            if (slot.CanBePlaced(card))
            {
                return slot.Cost(card, isFirstTurn) <= Resources.Craftsmans;
            }
            return false;
        }

        public void Build(ConstructionSlot slot, Building card, bool isFirstTurn)
        {
            int cost = slot.Cost(card, isFirstTurn);
            slot.Place(card);
            Resources.PayCraftsmen(cost);
            BuildingTypeStatuses.Enable(slot.Type);
        }

        public override string ToString() => City.ToString();
    }
}
