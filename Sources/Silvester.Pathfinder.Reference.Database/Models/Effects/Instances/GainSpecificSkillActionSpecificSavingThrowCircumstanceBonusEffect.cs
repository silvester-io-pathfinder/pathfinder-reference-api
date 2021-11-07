using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificSkillActionSpecificSavingThrowCircumstanceBonusEffect : BaseEffect
    {
        public string? Addendum { get; set; }

        public int Bonus { get; set; }

        public Guid SavingThrowStatId{ get; set; }
        public SavingThrowStat SavingThrowStat { get; set; } = default!;

        public Guid SkillActionId { get; set; }
        public SkillAction SkillAction { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(this BooleanEffectBuilder builder, Guid id, Guid savingThrowStatId, Guid skillActionId, int bonus, string? addendum = null)
        {
            return builder.Add(new GainSpecificSkillActionSpecificSavingThrowCircumstanceBonusEffect { Id = id, SavingThrowStatId = savingThrowStatId, SkillActionId = skillActionId, Bonus = bonus, Addendum = addendum });
        }
    }
}
