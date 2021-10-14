using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances
{
    public class CombinedPrerequisiteBinding : BasePrerequisiteBinding
    {
        public Guid CombinationId { get; set; }
        public CombinedPrerequisite Combination { get; set; } = default!;
    }
}
