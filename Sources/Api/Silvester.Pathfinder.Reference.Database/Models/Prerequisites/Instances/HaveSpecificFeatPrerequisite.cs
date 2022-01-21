using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificFeatPrerequisite : BasePrerequisite
    {
        public Guid RequiredFeatId { get; set; }
        public Feat RequiredFeat { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificFeat(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredFeatId)
        {
            return builder.Add(new HaveSpecificFeatPrerequisite { Id = id, RequiredFeatId = requiredFeatId });
        }
    }
}
