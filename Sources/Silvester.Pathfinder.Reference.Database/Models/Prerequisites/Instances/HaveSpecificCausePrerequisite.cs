using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificCausePrerequisite : BasePrerequisite
    {
        public Guid RequiredCauseId { get; set; }
        public Cause RequiredCause { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificCause (this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredCauseId)
        {
            return builder.Add(new HaveSpecificCausePrerequisite { Id = id, RequiredCauseId = requiredCauseId });
        }
    }
}
