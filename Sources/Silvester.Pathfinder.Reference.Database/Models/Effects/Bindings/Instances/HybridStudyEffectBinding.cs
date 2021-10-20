using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances
{
    public class HybridStudyEffectBinding : BaseEffectBinding
    {
        public Guid HybridStudyId { get; set; }
        public HybridStudy HybridStudy { get; set; } = default!;
    }
}
