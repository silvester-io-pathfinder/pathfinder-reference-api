using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificSpellCastingEffect : BaseEffect
    {
        public Guid MagicTraditionId { get; set; }
        public MagicTradition MagicTradition { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificSpellCasting(this BooleanEffectBuilder builder, Guid id, Guid magicTraditionId)
        {
            return builder.Add(new GainSpecificSpellCastingEffect { Id = id, MagicTraditionId = magicTraditionId });
        }
    }
}
