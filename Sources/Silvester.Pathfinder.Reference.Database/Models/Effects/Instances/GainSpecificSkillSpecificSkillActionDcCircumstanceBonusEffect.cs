using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificSkillSpecificSkillActionDcCircumstanceBonusEffect : BaseEffect
    {
        public string? Addendum { get; set; }

        public int Bonus { get; set; }

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; } = default!;

        public Guid SkillActionId { get; set; }
        public SkillAction SkillAction { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificSkillSpecificSkillActionDcCircumstanceBonus(this BooleanEffectBuilder builder, Guid id, Guid skillId, Guid skillActionId, int bonus, string? addendum = null)
        {
            return builder.Add(new GainSpecificSkillSpecificSkillActionDcCircumstanceBonusEffect { Id = id, SkillId = skillId, SkillActionId = skillActionId, Bonus = bonus, Addendum = addendum });
        }
    }
}
