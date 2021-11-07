using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificSkillDcCircumstanceBonusEffect : BaseEffect
    {
        public int Bonus { get; set; }

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificSkillDcCircumstanceBonus(this BooleanEffectBuilder builder, Guid id, Guid skillId, int bonus)
        {
            return builder.Add(new GainSpecificSkillDcCircumstanceBonusEffect { Id = id, SkillId = skillId, Bonus = bonus });
        }
    }
}
