using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances
{
    public class ClassFeatureEffectBinding : BaseEffectBinding
    {
        public Guid ClauseFeatureId { get; set; }
        public ClassFeature ClassFeature { get; set; } = default!;
    }
}
