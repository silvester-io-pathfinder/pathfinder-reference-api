using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificConditionAnySavingThrowCircumstanceBonusEffect : BaseEffect
    {
        public string? Addendum { get; set; }
        public int Bonus { get; set; }

        public Guid ConditionId { get; set; }
        public Condition Condition { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificConditionAnySavingThrowCircumstanceBonus(this BooleanEffectBuilder builder, Guid id, Guid conditionId, int bonus, string? addendum = null)
        {
            return builder.Add(new GainSpecificConditionAnySavingThrowCircumstanceBonusEffect { Id = id, ConditionId = conditionId, Bonus = bonus, Addendum = addendum });
        }
    }
}
