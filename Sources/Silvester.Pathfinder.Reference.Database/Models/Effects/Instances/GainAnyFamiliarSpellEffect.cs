using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using System;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyFamiliarSpellEffect : BaseEffect
    {
        public int SpellLevel { get; set; }
        public int Amount { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyFamiliarSpell(this BooleanEffectBuilder builder, Guid id, int spellLevel, int amount)
        {
            return builder.Add(new GainAnyFamiliarSpellEffect { Id = id, SpellLevel = spellLevel, Amount = amount });
        }
    
        public static EffectBuilder GainAnyFamiliarSpell(this BooleanEffectBuilder builder, Guid id, Guid prerequisiteId, int spellLevel, int amount, int requiredLevel)
        {
            return builder.Add(new GainAnyFamiliarSpellEffect { Id = id, SpellLevel = spellLevel, Amount = amount })
                .AddPrerequisites(id, prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(prerequisiteId, Comparator.GreaterThanOrEqualTo, requiredLevel);
                });
        }
    }
}

