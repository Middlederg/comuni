using System.Collections.Generic;
using System.Linq;

namespace Comuni.Core
{
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
}
