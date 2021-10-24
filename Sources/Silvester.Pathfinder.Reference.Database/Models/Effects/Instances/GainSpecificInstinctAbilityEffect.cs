using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpecificInstinctAbilityEffect : BaseEffect
    {
        public Guid InstinctAbilityId { get; set; }
        public InstinctAbility InstinctAbility  { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpecificInstinctAbility(this BooleanEffectBuilder builder, Guid id, Guid instinctAbilityId)
        {
            return builder.Add(new GainSpecificInstinctAbilityEffect { Id = id, InstinctAbilityId = instinctAbilityId });
        }
    }
}
