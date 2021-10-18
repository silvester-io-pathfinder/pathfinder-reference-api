using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificAncestryPrerequisite : Prerequisite
    {
        public Guid RequiredAncestryId { get; set; }
        public Ancestry RequiredAncestry { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites HaveSpecificAncestry(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Guid requiredAncestryId)
        {
            return builder.Add(bindingId, new HaveSpecificAncestryPrerequisite { Id = id, RequiredAncestryId = requiredAncestryId });
        }
    }
}
