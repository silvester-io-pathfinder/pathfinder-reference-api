using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificArmorCategorySpecializationEffect : BaseEffect
    {
        public Guid ArmorCategoryId { get; set; }
        public ArmorCategory ArmorCategory { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificArmorCategorySpecialization(this BooleanEffectBuilder builder, Guid id, Guid armorCategoryId)
        {
            return builder.Add(new GainSpecificArmorCategorySpecializationEffect { Id = id, ArmorCategoryId = armorCategoryId});
        }
    }
}
