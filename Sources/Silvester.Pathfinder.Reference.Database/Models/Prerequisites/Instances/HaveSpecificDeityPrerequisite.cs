using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificDeityPrerequisite : Prerequisite
    {
        public Guid RequiredDeityId { get; set; }
        public Deity RequiredDeity { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveSpecificDeity(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Guid requiredDeityId)
        {
            return builder.Add(bindingId, new HaveSpecificDeityPrerequisite { Id = id, RequiredDeityId = requiredDeityId });
        }
    }
}
