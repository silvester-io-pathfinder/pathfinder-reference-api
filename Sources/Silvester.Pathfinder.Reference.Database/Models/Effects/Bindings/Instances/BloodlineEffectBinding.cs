using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances
{
    public class BloodlineEffectBinding : BaseEffectBinding
    {
        public Guid BloodlineId { get; set; }
        public Bloodline Bloodline { get; set; } = default!;
    }
}
