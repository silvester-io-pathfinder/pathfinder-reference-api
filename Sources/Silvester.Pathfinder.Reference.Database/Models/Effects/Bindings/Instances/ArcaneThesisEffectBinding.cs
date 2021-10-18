using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances
{
    public class ArcaneThesisEffectBinding : BaseEffectBinding
    {
        public Guid ArcaneThesisId { get; set; }
        public ArcaneThesis ArcaneThesis { get; set; } = default!;
    }
}
