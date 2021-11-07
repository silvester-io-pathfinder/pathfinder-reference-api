using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificTraitAnySavingThrowCircumstanceBonusEffect : BaseEffect
    {
        public string? Addendum { get; set; }

        public int Bonus { get; set; }

        public Guid TraitId { get; set; }
        public Trait Trait { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificTraitAnySavingThrowCircumstanceBonus(this BooleanEffectBuilder builder, Guid id, Guid traitId, int bonus, string? addendum = null)
        {
            return builder.Add(new GainSpecificTraitAnySavingThrowCircumstanceBonusEffect { Id = id, TraitId = traitId, Bonus = bonus, Addendum = addendum });
        }
    }
}
