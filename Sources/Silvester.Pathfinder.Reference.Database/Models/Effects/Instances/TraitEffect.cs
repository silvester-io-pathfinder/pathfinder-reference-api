using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class TraitEffect : Effect
    {
        public Guid TraitId { get; set; }
        public Trait Trait { get; set; } = default!;
    }
}
