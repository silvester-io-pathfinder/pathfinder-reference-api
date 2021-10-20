using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificClassPrerequisite : Prerequisite
    {
        public Guid RequiredClassId { get; set; }
        public Class RequiredClass { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveSpecificClass(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Guid requiredClassId)
        {
            return builder.Add(bindingId, new HaveSpecificClassPrerequisite { Id = id, RequiredClassId = requiredClassId });
        }
    }
}
