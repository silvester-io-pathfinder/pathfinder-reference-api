using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances
{
    public class ChoicePrerequisiteBinding : BasePrerequisiteBinding
    {
        public Guid ChoiceId { get; set; }
        public ChoicePrerequisite Choice { get; set; } = default!;
    }
}
