using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances
{
    public class ChoiceEffectBinding : BaseEffectBinding
    {
        public Guid ChoiceId { get; set; }
        public ChoiceEffect Choice { get; set; } = default!;
    }
}
