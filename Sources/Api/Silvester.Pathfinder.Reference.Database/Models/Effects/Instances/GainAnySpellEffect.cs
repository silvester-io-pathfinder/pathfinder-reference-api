using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    /// <summary>
    /// Gain any spell for which you meet the requirements, and whose spellcasting tradition you have.
    /// </summary>
    public class GainAnySpellEffect : BaseEffect
    {
        public int Level { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnySpell(this BooleanEffectBuilder builder, Guid id, int spellLevel)
        {
            return builder.Add(new GainAnySpellEffect { Id = id, Level = spellLevel });
        }

        public static EffectBuilder GainAnySpell(this BooleanEffectBuilder builder, Guid id, Guid prerequisiteId, int spellLevel, int requiredLevel)
        {
            return builder.GainAnySpell(id, prerequisiteId, spellLevel, Comparator.GreaterThanOrEqualTo, requiredLevel);
        }

        public static EffectBuilder GainAnySpell(this BooleanEffectBuilder builder, Guid id, Guid prerequisiteId, int spellLevel, Comparator comparator, int requiredLevel)
        {
            EffectBuilder effect = builder.GainAnySpell(id, spellLevel);
            effect.AddPrerequisites(prerequisiteId, prerequisites =>
            {
                prerequisites.HaveSpecificLevel(id, comparator, requiredLevel: 2);
            });

            return effect;
        }
    }
}
