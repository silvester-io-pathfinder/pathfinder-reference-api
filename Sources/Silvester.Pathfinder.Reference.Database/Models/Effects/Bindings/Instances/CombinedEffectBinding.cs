using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances
{
    public class CombinedEffectBinding : BaseEffectBinding
    {
        public Guid CombinedId { get; set; }
        public CombinedEffect Combined { get; set; } = default!;
    }
}
