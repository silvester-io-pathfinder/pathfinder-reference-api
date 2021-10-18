using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificTraitEffect : Effect
    {
        public Guid TraitId { get; set; }
        public Trait Trait { get; set; } = default!;
    }
}
