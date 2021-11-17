using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificAbilityEffect : BaseEffect
    {
        public string? Range { get; set; }

        public Guid AbilityId { get; set; }
        public Ability Ability { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificAbility(this BooleanEffectBuilder builder, Guid id, Guid abilityId, string? range = null)
        {
            return builder.Add(new GainSpecificAbilityEffect { Id = id, AbilityId = abilityId, Range = range });
        }
    }
}
