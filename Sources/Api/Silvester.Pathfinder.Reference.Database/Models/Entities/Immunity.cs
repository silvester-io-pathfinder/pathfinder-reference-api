using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Immunity : BaseEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Hazard> Hazards { get; set; } = default!;
        public ICollection<Creature> Creatures { get; set; } = default!;
    }
}
