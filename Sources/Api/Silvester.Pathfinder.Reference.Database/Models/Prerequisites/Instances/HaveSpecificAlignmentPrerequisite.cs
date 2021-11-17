using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificAlignmentPrerequisite : BasePrerequisite
    {
        public Guid RequiredAlignmentId { get; set; }
        public Alignment RequiredAlignment { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificAlignment(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredAlignmentId)
        {
            return builder.Add(new HaveSpecificAlignmentPrerequisite { Id = id, RequiredAlignmentId = requiredAlignmentId });
        }
    }
}
