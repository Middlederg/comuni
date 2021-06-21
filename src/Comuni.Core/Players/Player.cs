using System.Collections.Generic;
using System.Linq;

namespace Comuni.Core
{
    public class BuildingTypeStatuses
    {
        private readonly IEnumerable<BuildingTypeStatus> buildingTypeStatuses;
        private BuildingTypeStatus OfType(BuildingType type) => buildingTypeStatuses.FirstOrDefault(x => x.Type.Equals(type));

        public bool WouldCollect(BuildingType type) => OfType(type)?.Active ?? false;
        public void Enable(BuildingType type) => OfType(type)?.Activate();
        public void Reset()
        {
            foreach (var status in buildingTypeStatuses)
            {
                status.Reset();
            }
        }

        public BuildingTypeStatuses()
        {
            buildingTypeStatuses = new List<BuildingTypeStatus>()
            {
                new BuildingTypeStatus(BuildingTypeFactory.Economic),
                new BuildingTypeStatus(BuildingTypeFactory.Military),
                new BuildingTypeStatus(BuildingTypeFactory.Cultural),
                new BuildingTypeStatus(BuildingTypeFactory.Religious),
            };
        }

    }

    public class Slots
    {
        private readonly List<ConstructionSlot> slots;
        public IEnumerable<ConstructionSlot> SlotsOfType(BuildingType type) => slots.Where(x => x.Type.Equals(type));

        public Slots()
        {
            slots = new List<ConstructionSlot>();
        }

        public ConstructionSlot Create(BuildingType type)
        {
            var slot = new ConstructionSlot(type);
            slots.Add(slot);
            return slot;
        }
    }
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
