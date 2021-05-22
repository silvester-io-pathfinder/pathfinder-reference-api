using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class HazardComplexity : BaseEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Hazard> Hazards { get; set; } = new List<Hazard>();
    }
}
