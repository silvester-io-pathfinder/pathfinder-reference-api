using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances
{
    public class EffectPrerequisiteBinding : BasePrerequisiteBinding
    {
        public Guid EffectId { get; set; }
        public Effect Effect { get; set; } = default!;
    }
}
