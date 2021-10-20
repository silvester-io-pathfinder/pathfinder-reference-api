using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances
{
    public class MethodologyEffectBinding : BaseEffectBinding
    {
        public Guid MethodologyId { get; set; }
        public Methodology Methodology { get; set; } = default!;
    }
}
