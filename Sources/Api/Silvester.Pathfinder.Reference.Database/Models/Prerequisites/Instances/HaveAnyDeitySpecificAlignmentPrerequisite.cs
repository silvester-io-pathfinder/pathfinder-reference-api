using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveAnyDeitySpecificAlignmentPrerequisite : BasePrerequisite
    {
        public Guid RequiredAlignmentId { get; set; }
        public Alignment RequiredAlignment { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveAnyDeitySpecificAlignment(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredAlignmentId)
        {
            return builder.Add(new HaveAnyDeitySpecificAlignmentPrerequisite { Id = id, RequiredAlignmentId = requiredAlignmentId });
        }
    }
}
