using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances
{
    public class InstinctEffectBinding : BaseEffectBinding
    {
        public Guid InstinctId { get; set; }
        public Instinct Instinct { get; set; } = default!;
    }
}
