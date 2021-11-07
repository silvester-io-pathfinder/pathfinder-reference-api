using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificSkillActionCircumstanceBonusEffect : BaseEffect
    {
        public string? Addendum { get; set; }
        public int Bonus { get; set; }

        public Guid SkillActionId { get; set; }
        public SkillAction SkillAction { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificSkillActionCircumstanceBonus(this BooleanEffectBuilder builder, Guid id, Guid skillActionId, int bonus, string? addendum = null)
        {
            return builder.Add(new GainSpecificSkillActionCircumstanceBonusEffect { Id = id, SkillActionId = skillActionId,Bonus = bonus, Addendum = addendum });
        }
    }
}
