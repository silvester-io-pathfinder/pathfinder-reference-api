using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances
{
    public class FeatEffectBinding : BaseEffectBinding
    {
        public Guid FeatId { get; set; }
        public Feat Feat { get; set; } = default!;
    }
}
