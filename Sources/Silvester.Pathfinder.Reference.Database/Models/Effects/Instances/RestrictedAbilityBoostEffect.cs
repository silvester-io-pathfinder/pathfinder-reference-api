using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class RestrictedAbilityBoostEffect : Effect
    {
        public ICollection<StatEffectBinding> RequiredStats { get; set; } = default!;
    }
}
