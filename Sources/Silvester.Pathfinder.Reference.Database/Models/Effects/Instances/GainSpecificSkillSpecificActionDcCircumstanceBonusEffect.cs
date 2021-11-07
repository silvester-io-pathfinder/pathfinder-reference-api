using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificSkillSpecificActionDcCircumstanceBonusEffect : BaseEffect
    {
        public string? Addendum { get; set; }

        public int Bonus { get; set; }

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; } = default!;

        public Guid ActionId { get; set; }
        public Models.Entities.Action Action { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificSkillSpecificActionDcCircumstanceBonus(this BooleanEffectBuilder builder, Guid id, Guid skillId, Guid actionId, int bonus, string? addendum = null)
        {
            return builder.Add(new GainSpecificSkillSpecificActionDcCircumstanceBonusEffect { Id = id, SkillId = skillId, ActionId = actionId, Bonus = bonus, Addendum = addendum });
        }
    }
}
