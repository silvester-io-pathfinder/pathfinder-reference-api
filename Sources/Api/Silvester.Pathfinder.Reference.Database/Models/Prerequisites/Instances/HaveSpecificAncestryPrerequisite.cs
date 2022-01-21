using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificAncestryPrerequisite : BasePrerequisite
    {
        public Guid RequiredAncestryId { get; set; }
        public Ancestry RequiredAncestry { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificAncestry(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredAncestryId)
        {
            return builder.Add(new HaveSpecificAncestryPrerequisite { Id = id, RequiredAncestryId = requiredAncestryId });
        }
    }
}
