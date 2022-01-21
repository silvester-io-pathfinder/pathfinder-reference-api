using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificClassFeaturePrerequisite : BasePrerequisite
    {
        public Guid RequiredClassFeatureId{ get; set; }
        public ClassFeature RequiredClassFeature { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificClassFeature(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredClassFeatureId)
        {
            return builder.Add(new HaveSpecificClassFeaturePrerequisite { Id = id, RequiredClassFeatureId = requiredClassFeatureId });
        }
    }
}
