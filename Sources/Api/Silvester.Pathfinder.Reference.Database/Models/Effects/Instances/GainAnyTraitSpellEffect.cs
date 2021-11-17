using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using System;

namespace Silvester.Pathfinder.Reference.Database.Effects.Instances
{
    public class GainAnyTraitSpellEffect : BaseEffect
    {
        public int Level { get; set; }

        public Guid RequiredTraitId { get; set; }
        public Trait RequiredTrait { get; set; } = default!;
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static EffectBuilder GainAnyTraitSpell(this BooleanEffectBuilder builder, Guid id, Guid requiredTraitId, int level)
        {
            return builder.Add(new GainAnyTraitSpellEffect { Id = id, RequiredTraitId = requiredTraitId, Level = level });
        }
    }
}
