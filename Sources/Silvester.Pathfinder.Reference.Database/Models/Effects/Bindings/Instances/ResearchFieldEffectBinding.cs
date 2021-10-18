using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances
{
    public class ResearchFieldEffectBinding : BaseEffectBinding
    {
        public Guid ResearchFieldId { get; set; }
        public ResearchField ResearchField { get; set; } = default!;
    }
}
