using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances
{
    public class FeatPrerequisiteBinding : BasePrerequisiteBinding
    {
        public Guid FeatId { get; set; }
        public Feat Feat { get; set; } = default!;
    }
}
