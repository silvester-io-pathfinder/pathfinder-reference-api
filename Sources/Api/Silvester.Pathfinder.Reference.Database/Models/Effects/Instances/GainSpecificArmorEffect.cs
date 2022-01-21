using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificArmorEffect : BaseEffect
    {
        public Guid ArmorId { get; set; }
        public Armor Armor { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificArmor(this BooleanEffectBuilder builder, Guid id, Guid armorId)
        {
            return builder.Add(new GainSpecificArmorEffect { Id = id, ArmorId = armorId });
        }
    }
}
