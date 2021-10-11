using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances
{
    public class ChoicePrerequisiteBinding : BasePrerequisiteBinding
    {
        public Guid PrerequisiteId { get; set; }
        public ChoicePrerequisite Prerequisite { get; set; } = default!;
    }
}
