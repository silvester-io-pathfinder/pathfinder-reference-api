using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyMagicTraditionSpellEffect : BaseEffect
    {
        public int Level { get; set; }

        public Guid MagicTraditionId { get; set; }
        public MagicTradition MagicTradition { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyMagicTraditionSpell(this BooleanEffectBuilder builder, Guid id, Guid magicTraditionId, int spellLevel)
        {
            return builder.Add(new GainAnyMagicTraditionSpellEffect { Id = id, MagicTraditionId = magicTraditionId, Level = spellLevel});
        }

        public static EffectBuilder GainAnyMagicTraditionSpell(this BooleanEffectBuilder builder, Guid id, Guid prerequisiteId, Guid magicTraditionId, int spellLevel, int requiredLevel)
        {
            EffectBuilder effect = builder.GainAnyMagicTraditionSpell(id, magicTraditionId, spellLevel);
            effect.AddPrerequisites(prerequisiteId, prerequisites =>
            {
                prerequisites.HaveSpecificLevel(id, Comparator.GreaterThanOrEqualTo, requiredLevel: 2);
            });

            return effect;
        }
    }
}
