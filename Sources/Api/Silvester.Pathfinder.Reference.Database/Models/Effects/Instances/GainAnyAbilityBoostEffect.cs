using System;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyAbilityBoostEffect : BaseEffect
    {
        public bool IsChosenByGameMaster { get; set; } = false;
        public string? Restrictions { get; set; }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyAbilityBoost(this BooleanEffectBuilder builder, Guid id, bool isChosenByGameMaster = false, string? restrictions = null)
        {
            return builder.Add(new GainAnyAbilityBoostEffect { Id = id, IsChosenByGameMaster = isChosenByGameMaster, Restrictions = restrictions });
        }

        public static EffectBuilder GainAnyAbilityBoost(this BooleanEffectBuilder builder, Guid id, Guid prerequisiteId, int requiredLevel, bool isChosenByGameMaster = false, string? restrictions = null)
        {
            EffectBuilder effect = builder.GainAnyAbilityBoost(id, isChosenByGameMaster, restrictions);
            effect.AddPrerequisites(prerequisiteId, prerequisites => 
            {
                prerequisites.HaveSpecificLevel(id, Comparator.GreaterThanOrEqualTo, requiredLevel);
            });

            return effect;
        }
    }
}
