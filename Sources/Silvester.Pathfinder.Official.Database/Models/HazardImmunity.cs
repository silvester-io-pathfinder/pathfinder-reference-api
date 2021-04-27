using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class HazardImmunity : BaseEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Hazard> Hazards { get; set; } = default!;
    }
}
