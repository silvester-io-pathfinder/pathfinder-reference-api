using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificInstinctEffect : Effect
    {
        public Guid InstinctId { get; set; }
        public Instinct Instinct { get; set; } = default!;
    }
}
