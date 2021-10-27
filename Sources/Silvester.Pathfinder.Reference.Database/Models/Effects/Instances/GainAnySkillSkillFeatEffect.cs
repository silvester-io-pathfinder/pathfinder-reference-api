using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnySkillSkillFeatEffect : BaseEffect
    {
        public Guid SkillId { get; set; }
        public Skill Skill { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnySkillSkillFeat(this BooleanEffectBuilder builder, Guid id, Guid skillId)
        {
            return builder.Add(new GainAnySkillSkillFeatEffect { Id = id, SkillId = skillId });
        }

        public static EffectBuilder GainAnySkillSkillFeat(this BooleanEffectBuilder builder, Guid id, Guid prerequisiteId, Guid skillId, int requiredLevel)
        {
            return builder
                .GainAnySkillSkillFeat(id, skillId)
                .AddPrerequisites(prerequisiteId, prerequisites =>
                {
                    prerequisites.HaveSpecificLevel(id, Comparator.GreaterThanOrEqualTo, requiredLevel);
                });
        }
    }
}

