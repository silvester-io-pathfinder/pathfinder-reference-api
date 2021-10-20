using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances
{
    public class InnovationModificationEffectBinding : BaseEffectBinding
    {
        public Guid InnovationModificationId { get; set; }
        public InnovationModification InnovationModification { get; set; } = default!;
    }
    

}
