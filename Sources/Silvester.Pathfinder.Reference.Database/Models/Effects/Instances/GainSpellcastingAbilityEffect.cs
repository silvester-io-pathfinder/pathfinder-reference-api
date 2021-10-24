using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainSpellcastingAbilityEffect : BaseEffect
    {
        public Guid StatId { get; set; }
        public Stat Stat { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainSpellcastingAbility(this BooleanEffectBuilder builder, Guid id, Guid statId)
        {
            return builder.Add(new GainSpellcastingAbilityEffect { Id = id, StatId = statId });
        }
    }
}
