using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances
{
    public class BackgroundPrerequisiteBinding : BasePrerequisiteBinding
    {
        public Guid BackgroundId { get; set; }
        public Background Background { get; set; } = default!;
    }
}
