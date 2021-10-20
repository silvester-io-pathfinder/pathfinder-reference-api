using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances
{
    public class InnovationModificationPrerequisiteBinding : BasePrerequisiteBinding
    {
        public Guid InnovationModificationId { get; set; }
        public InnovationModification InnovationModification { get; set; } = default!;
    }
}
