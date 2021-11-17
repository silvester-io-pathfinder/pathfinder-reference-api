using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificMagicSchoolAnySavingThrowCircumstanceBonusEffect : BaseEffect
    {
        public string? Addendum { get; set; }

        public int Bonus { get; set; }

        public Guid MagicSchoolId { get; set; }
        public MagicSchool MagicSchool { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificMagicSchoolAnySavingThrowCircumstanceBonus(this BooleanEffectBuilder builder, Guid id, Guid magicSchoolId, int bonus, string? addendum = null)
        {
            return builder.Add(new GainSpecificMagicSchoolAnySavingThrowCircumstanceBonusEffect { Id = id, MagicSchoolId = magicSchoolId, Bonus = bonus, Addendum = addendum });
        }
    }
}
