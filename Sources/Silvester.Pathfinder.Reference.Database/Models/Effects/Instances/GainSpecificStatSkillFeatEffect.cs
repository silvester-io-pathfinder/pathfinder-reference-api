using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificStatSkillFeatEffect : BaseEffect
    {
        public Guid StatId { get; set; }
        public Stat Stat { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificStatSkillFeat(this BooleanEffectBuilder builder, Guid id, Guid statId)
        {
            return builder.Add(new GainSpecificStatSkillFeatEffect { Id = id, StatId = statId });
        }

        public static EffectBuilder GainSpecificStatSkillFeat(this BooleanEffectBuilder builder, Guid id, Guid prerequisiteId, Guid statId, int requiredLevel)
        {
            return builder
                .GainSpecificStatSkillFeat(id, statId)
                .AddPrerequisites(prerequisiteId, prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(id, Comparator.GreaterThanOrEqualTo, requiredLevel);
                });
        }
    }
}

