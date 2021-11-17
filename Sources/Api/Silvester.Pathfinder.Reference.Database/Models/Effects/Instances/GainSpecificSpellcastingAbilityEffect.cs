using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificSpellcastingAbilityEffect : BaseEffect
    {
        public Guid StatId { get; set; }
        public Stat Stat { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificSpellcastingAbility(this BooleanEffectBuilder builder, Guid id, Guid statId)
        {
            return builder.Add(new GainSpecificSpellcastingAbilityEffect { Id = id, StatId = statId });
        }
    }
}