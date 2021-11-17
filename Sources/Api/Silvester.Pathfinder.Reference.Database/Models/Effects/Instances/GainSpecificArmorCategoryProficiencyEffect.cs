using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificArmorCategoryProficiencyEffect : BaseEffect
    {
        public Guid ArmorCategoryId { get; set; }
        public ArmorCategory ArmorCategory { get; set; } = default!;

        public Guid ProficiencyId { get; set; }
        public Proficiency Proficiency { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificArmorCategoryProficiency(this BooleanEffectBuilder builder, Guid id, Guid proficiencyId, Guid armorCategoryId )
        {
            return builder.Add(new GainSpecificArmorCategoryProficiencyEffect { Id = id, ProficiencyId = proficiencyId, ArmorCategoryId = armorCategoryId });
        }
    }
}
