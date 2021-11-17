using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class HaveSpecificBloodlinePrerequisite : BasePrerequisite
    {
        public Guid RequiredBloodlineId { get; set; }
        public Bloodline RequiredBloodline { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder HaveSpecificBloodline(this BooleanPrerequisiteBuilder builder, Guid id, Guid requiredBloodlineId)
        {
            return builder.Add(new HaveSpecificBloodlinePrerequisite { Id = id, RequiredBloodlineId = requiredBloodlineId });
        }
    }
}
