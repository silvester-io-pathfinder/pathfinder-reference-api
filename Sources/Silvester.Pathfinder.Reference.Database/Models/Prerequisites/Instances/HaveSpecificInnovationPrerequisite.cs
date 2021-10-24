using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificInnovationPrerequisite : BasePrerequisite
    {
        public Guid InnovationId { get; set; }
        public Innovation Innovation { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificInnovation(this BooleanPrerequisiteBuilder builder, Guid id, Guid innovationId)
        {
            return builder.Add(new HaveSpecificInnovationPrerequisite { Id = id, InnovationId = innovationId });
        }
    }
}
