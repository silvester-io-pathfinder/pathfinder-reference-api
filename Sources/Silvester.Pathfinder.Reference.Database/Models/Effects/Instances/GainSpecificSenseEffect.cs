using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificSenseEffect : Effect
    {
        public string? Range { get; set; }

        public Guid SenseId { get; set; }
        public Sense Sense { get; set; } = default!;
    }
}
