using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances
{
    public class BackgroundEffectBinding : BaseEffectBinding
    {
        public Guid BackgroundId { get; set; }
        public Background Background { get; set; } = default!;
    }
}
