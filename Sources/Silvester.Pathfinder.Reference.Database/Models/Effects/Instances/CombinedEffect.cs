using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class CombinedEffect : Effect, IEffectCollection<CombinedEffectBinding>
    {
        public string? Addendum { get; set; }

        public ICollection<CombinedEffectBinding> Entries { get; set; } = new List<CombinedEffectBinding>();
    }
}
