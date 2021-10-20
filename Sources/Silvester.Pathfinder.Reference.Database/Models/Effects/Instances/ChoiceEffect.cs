using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class ChoiceEffect : Effect, IEffectCollection<ChoiceEffectBinding>
    {
        public string? Restrictions { get; set; }

        public ICollection<ChoiceEffectBinding> Entries { get; set; } = new List<ChoiceEffectBinding>();
    }
}
