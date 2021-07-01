using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Immunity : BaseEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Hazard> Hazards { get; set; } = default!;
        public ICollection<Creature> Creatures { get; set; } = default!;
    }
}
