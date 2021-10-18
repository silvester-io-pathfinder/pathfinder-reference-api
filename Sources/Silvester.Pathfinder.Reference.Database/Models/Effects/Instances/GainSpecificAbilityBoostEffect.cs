using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class GainSpecificAbilityBoostEffect : Effect
    {
        public ICollection<StatEffectBinding> RequiredStats { get; set; } = default!;
    }
}
