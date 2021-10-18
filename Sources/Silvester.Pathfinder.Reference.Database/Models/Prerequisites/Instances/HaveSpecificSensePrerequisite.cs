using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificSensePrerequisite : Prerequisite
    {
        public Guid RequiredSenseId { get; set; } 
        public Sense RequiredSense { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveSpecificSense(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Guid requiredSenseId)
        {
            return builder.Add(bindingId, new HaveSpecificSensePrerequisite { Id = id, RequiredSenseId = requiredSenseId});
        }
    }
}
