using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances
{
    public class InnovationEffectBinding : BaseEffectBinding
    {
        public Guid InnovationId { get; set; }
        public Innovation Innovation { get; set; } = default!;
    }
}
