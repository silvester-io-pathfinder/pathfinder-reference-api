using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificSizePrerequisite : BasePrerequisite
    {
        public Guid RequiredSizeId { get; set; }
        public AncestrySize RequiredSize { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificSize(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredSizeId)
        {
            return builder.Add(new HaveSpecificSizePrerequisite { Id = id, RequiredSizeId = requiredSizeId });
        }
    }
}
