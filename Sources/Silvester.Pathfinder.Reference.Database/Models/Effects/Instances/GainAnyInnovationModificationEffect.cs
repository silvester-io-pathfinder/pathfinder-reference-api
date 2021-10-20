using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainAnyInnovationModificationEffect : Effect
    {
        public Guid InnovationModificationTypeId { get; set; }
        public InnovationModificationType InnovationModificationType { get; set; } = default!;
    }
}
